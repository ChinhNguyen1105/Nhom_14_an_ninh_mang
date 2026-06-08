using System;
using System.IO;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace UI_CSharp
{
    public class RSAService
    {
        // =====================================================
        // STATE
        // =====================================================
        public string XmlPublicKey { get; set; }
        public string XmlPrivateKey { get; set; }

        // Lưu lại các tham số RSA thủ công để hiển thị / debug nếu cần
        public BigInteger ManualN { get; private set; }
        public BigInteger ManualE { get; private set; }
        public BigInteger ManualD { get; private set; }

        // =====================================================
        // GENERATE KEY — Tự động (theo keySize bit)
        // =====================================================
        public void GenerateKeyPair(int keySize)
        {
            using RSA rsa = RSA.Create(keySize);
            XmlPublicKey = rsa.ToXmlString(false);
            XmlPrivateKey = rsa.ToXmlString(true);
        }

        // =====================================================
        // GENERATE KEY — Thủ công (p, q, e do người dùng nhập)
        //
        // Trả về true nếu thành công, false + error nếu thất bại.
        //
        // FIX 0x81090029: halfLen = modLen / 2  (không +1)
        // .NET ImportParameters() yêu cầu:
        //   P.Length == Q.Length == Modulus.Length / 2  (chính xác)
        //   D.Length == Modulus.Length
        //   DP.Length == DQ.Length == InverseQ.Length == Modulus.Length / 2
        // =====================================================
        public bool GenerateKeyPairManual(string pInput, string qInput, string eInput, out string error)
        {
            error = string.Empty;
            try
            {
                BigInteger p = ParseToBigInteger(pInput.Trim());
                BigInteger q = ParseToBigInteger(qInput.Trim());
                BigInteger e = string.IsNullOrWhiteSpace(eInput)
                    ? 65537
                    : ParseToBigInteger(eInput.Trim());

                // --- Validate ---
                if (p <= 1) { error = "p phải là số nguyên tố lớn hơn 1."; return false; }
                if (q <= 1) { error = "q phải là số nguyên tố lớn hơn 1."; return false; }
                if (p == q) { error = "p và q phải là hai số nguyên tố khác nhau."; return false; }

                if (!IsProbablyPrime(p))
                { error = $"p = {p} không phải số nguyên tố."; return false; }
                if (!IsProbablyPrime(q))
                { error = $"q = {q} không phải số nguyên tố."; return false; }

                int pBits = (int)p.GetBitLength();
                int qBits = (int)q.GetBitLength();
                if (pBits < 512 || qBits < 512)
                {
                    error = $"p/q quá nhỏ ({pBits} bit / {qBits} bit). Yêu cầu mỗi số ≥ 512 bit để tạo RSA-1024.";
                    return false;
                }

                BigInteger n = p * q;
                BigInteger phi = (p - 1) * (q - 1);

                if (Gcd(e, phi) != BigInteger.One)
                { error = $"e = {e} không nguyên tố cùng nhau với phi(n). Hãy thử lại với e = 65537."; return false; }

                BigInteger d = ModInverse(e, phi);
                BigInteger dp = d % (p - 1);
                BigInteger dq = d % (q - 1);
                BigInteger qInv = ModInverse(q, p);

                // --- Tính kích thước byte ---
                byte[] modBytes = BigIntToBigEndianBytes(n);
                int modLen = modBytes.Length;
                int halfLen = modLen / 2;   // FIX: bỏ +1

                byte[] pBytes = BigIntToBigEndianBytes(p);
                byte[] qBytes = BigIntToBigEndianBytes(q);
                if (pBytes.Length > halfLen)
                { error = $"p chiếm {pBytes.Length} byte nhưng halfLen = {halfLen}. Cần p và q có kích thước tương đương nhau."; return false; }
                if (qBytes.Length > halfLen)
                { error = $"q chiếm {qBytes.Length} byte nhưng halfLen = {halfLen}. Cần p và q có kích thước tương đương nhau."; return false; }

                RSAParameters rsaParams = new RSAParameters
                {
                    Modulus = modBytes,
                    Exponent = BigIntToBigEndianBytes(e),
                    D = PadLeft(BigIntToBigEndianBytes(d), modLen),
                    P = PadLeft(pBytes, halfLen),
                    Q = PadLeft(qBytes, halfLen),
                    DP = PadLeft(BigIntToBigEndianBytes(dp), halfLen),
                    DQ = PadLeft(BigIntToBigEndianBytes(dq), halfLen),
                    InverseQ = PadLeft(BigIntToBigEndianBytes(qInv), halfLen),
                };

                using RSA rsa = RSA.Create();
                rsa.ImportParameters(rsaParams);

                XmlPublicKey = rsa.ToXmlString(false);
                XmlPrivateKey = rsa.ToXmlString(true);
                ManualN = n;
                ManualE = e;
                ManualD = d;

                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        // =====================================================
        // GỢI Ý SỐ NGUYÊN TỐ (dùng bởi btnSuggestP / btnSuggestQ trên Form)
        // =====================================================
        /// <summary>
        /// Sinh ngẫu nhiên một số nguyên tố có đúng <paramref name="bits"/> bit.
        /// </summary>
        public BigInteger GeneratePrimeForUI(int bits)
        {
            if (bits < 8) bits = 8;
            return GenerateLargePrime(bits);
        }

        // =====================================================
        // SIGN / VERIFY TEXT
        // =====================================================
        public string SignData(string text)
        {
            byte[] data = Encoding.UTF8.GetBytes(text);
            using RSA rsa = RSA.Create();
            rsa.FromXmlString(XmlPrivateKey);
            return Convert.ToBase64String(
                rsa.SignData(data, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1));
        }

        public bool VerifyData(string text, string signature)
        {
            byte[] data = Encoding.UTF8.GetBytes(text);
            byte[] sig = Convert.FromBase64String(signature);
            using RSA rsa = RSA.Create();
            rsa.FromXmlString(XmlPublicKey);
            return rsa.VerifyData(data, sig, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
        }

        // =====================================================
        // SIGN / VERIFY FILE
        // =====================================================
        public string SignFile(string filePath)
        {
            byte[] fileData = File.ReadAllBytes(filePath);
            using RSA rsa = RSA.Create();
            rsa.FromXmlString(XmlPrivateKey);
            return Convert.ToBase64String(
                rsa.SignData(fileData, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1));
        }

        public bool VerifyFile(string filePath, string signature)
        {
            byte[] fileData = File.ReadAllBytes(filePath);
            byte[] sig = Convert.FromBase64String(signature);
            using RSA rsa = RSA.Create();
            rsa.FromXmlString(XmlPublicKey);
            return rsa.VerifyData(fileData, sig, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
        }

        // =====================================================
        // PRIME GENERATION (internal)
        // =====================================================
        private BigInteger GenerateLargePrime(int bits)
        {
            using RandomNumberGenerator rng = RandomNumberGenerator.Create();
            int byteLength = (bits + 7) / 8;
            byte[] bytes = new byte[byteLength];

            while (true)
            {
                rng.GetBytes(bytes);

                // Ép đúng kích thước bit
                int excessBits = byteLength * 8 - bits;
                if (excessBits > 0)
                {
                    bytes[0] &= (byte)(0xFF >> excessBits);
                    bytes[0] |= (byte)(1 << (7 - excessBits));
                }
                else
                {
                    bytes[0] |= 0x80;
                }

                bytes[^1] |= 0x01; // luôn lẻ

                BigInteger candidate = new BigInteger(bytes, isUnsigned: true, isBigEndian: true);
                if (candidate > 1 && IsProbablyPrime(candidate))
                    return candidate;
            }
        }

        // =====================================================
        // MATH HELPERS
        // =====================================================
        private BigInteger Gcd(BigInteger a, BigInteger b)
        {
            while (b != BigInteger.Zero)
                (a, b) = (b, a % b);
            return BigInteger.Abs(a);
        }

        private BigInteger ModInverse(BigInteger a, BigInteger m)
        {
            if (m <= 0) throw new ArgumentException("Modulus phải dương.");
            if (m == 1) return BigInteger.Zero;

            BigInteger m0 = m;
            BigInteger x0 = BigInteger.Zero;
            BigInteger x1 = BigInteger.One;
            BigInteger r = a % m;
            if (r < 0) r += m;
            BigInteger rPrev = m;

            while (r > BigInteger.One)
            {
                if (rPrev == BigInteger.Zero)
                    throw new InvalidOperationException("ModInverse: gcd(a,m) ≠ 1.");

                BigInteger q = r / rPrev;
                BigInteger t = rPrev;
                rPrev = r % rPrev;
                r = t;
                t = x0;
                x0 = x1 - q * x0;
                x1 = t;
            }

            return x1 < 0 ? x1 + m0 : x1;
        }

        private bool IsProbablyPrime(BigInteger n, int extraRounds = 20)
        {
            if (n < 2) return false;
            if (n == 2 || n == 3) return true;
            if (n % 2 == 0) return false;

            BigInteger d = n - 1;
            int r = 0;
            while (d % 2 == 0) { d >>= 1; r++; }

            BigInteger[] witnesses = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37 };
            foreach (BigInteger a in witnesses)
            {
                if (a >= n) continue;
                if (!MillerRabinRound(n, d, r, a)) return false;
            }

            if (n > BigInteger.Parse("3317044064679887385961981"))
            {
                using RandomNumberGenerator rng = RandomNumberGenerator.Create();
                for (int i = 0; i < extraRounds; i++)
                {
                    byte[] buf = n.ToByteArray();
                    BigInteger a;
                    do
                    {
                        rng.GetBytes(buf);
                        buf[^1] &= 0x7F;
                        a = new BigInteger(buf);
                    } while (a < 2 || a >= n - 1);

                    if (!MillerRabinRound(n, d, r, a)) return false;
                }
            }

            return true;
        }

        private bool MillerRabinRound(BigInteger n, BigInteger d, int r, BigInteger a)
        {
            BigInteger x = BigInteger.ModPow(a, d, n);
            if (x == BigInteger.One || x == n - 1) return true;
            for (int i = 0; i < r - 1; i++)
            {
                x = BigInteger.ModPow(x, 2, n);
                if (x == n - 1) return true;
            }
            return false;
        }

        // =====================================================
        // BYTE HELPERS
        // =====================================================
        private byte[] BigIntToBigEndianBytes(BigInteger value)
        {
            if (value < 0)
                throw new ArgumentException("Chỉ dùng cho số dương.");
            return value.ToByteArray(isUnsigned: true, isBigEndian: true);
        }

        private byte[] PadLeft(byte[] data, int targetLength)
        {
            if (data.Length == targetLength) return data;
            if (data.Length > targetLength)
                throw new CryptographicException(
                    $"Component RSA dài {data.Length} byte vượt quá giới hạn {targetLength} byte.");

            byte[] padded = new byte[targetLength];
            Array.Copy(data, 0, padded, targetLength - data.Length, data.Length);
            return padded;
        }

        // =====================================================
        // PARSER
        // =====================================================
        private BigInteger ParseToBigInteger(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("Giá trị không được để trống.");

            if (input.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
            {
                string hex = input.Substring(2);
                if (BigInteger.TryParse("0" + hex,
                    System.Globalization.NumberStyles.HexNumber, null, out BigInteger hexVal))
                {
                    if (hexVal <= 0) throw new ArgumentException($"Giá trị hex '{input}' phải dương.");
                    return hexVal;
                }
                throw new ArgumentException($"Hex không hợp lệ: '{input}'.");
            }

            if (BigInteger.TryParse(input, out BigInteger result))
            {
                if (result <= 0) throw new ArgumentException($"'{input}' phải là số dương.");
                return result;
            }

            throw new ArgumentException($"Không thể parse '{input}'. Nhập số thập phân hoặc hex (0x...).");
        }
    }
}