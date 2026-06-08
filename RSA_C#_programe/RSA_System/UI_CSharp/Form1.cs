using System;
using System.Drawing;
using System.IO;
using System.Numerics;
using System.Windows.Forms;
using UI_CSharp;

namespace RSA_Signature_App
{
    public partial class Form1 : Form
    {
        private readonly RSAService _rsaService;

        public Form1()
        {
            InitializeComponent();
            _rsaService = new RSAService();

            InitializeDefaultSettings();
            RegisterFormEvents();
        }

        private void InitializeDefaultSettings()
        {
            cbKeyLength.Items.Clear();
            cbKeyLength.Items.AddRange(new object[] { 1024, 2048, 3072, 4096 });
            cbKeyLength.SelectedIndex = 1; // 2048 mặc định

            ToggleManualKeyControls(chkManualKey.Checked);
        }

        private void RegisterFormEvents()
        {
            btnAutoKey.Click += BtnAutoKey_Click;
            chkManualKey.CheckedChanged += ChkManualKey_CheckedChanged;
            btnConfirmKey.Click += BtnConfirmKey_Click;

            btnSuggestP.Click += BtnSuggestP_Click;
            btnSuggestQ.Click += BtnSuggestQ_Click;

            btnSignText.Click += BtnSignText_Click;
            btnVerifyTextSignature.Click += BtnVerifyTextSignature_Click;
            btnChooseFile.Click += BtnChooseFile_Click;
            btnSignFile.Click += BtnSignFile_Click;
            btnVerifyFileSignature.Click += BtnVerifyFileSignature_Click;

            // Import/Export Public Key
            btnImportPublicKey.Click += (s, e) =>
            {
                string imported = ImportTextFromFile("Khóa công khai (*.pub.xml)|*.pub.xml", "Khóa công khai");
                if (!string.IsNullOrEmpty(imported))
                {
                    rtbPublicKey.Text = imported;
                    _rsaService.XmlPublicKey = imported;
                }
            };
            btnExportPublicKey.Click += (s, e) =>
                ExportTextToFile(rtbPublicKey.Text, "Khóa công khai (*.pub.xml)|*.pub.xml", "Khóa công khai");

            // Import/Export Private Key
            btnImportPrivateKey.Click += (s, e) =>
            {
                string imported = ImportTextFromFile("Khóa bí mật (*.priv.xml)|*.priv.xml", "Khóa bí mật");
                if (!string.IsNullOrEmpty(imported))
                {
                    rtbPrivateKey.Text = imported;
                    _rsaService.XmlPrivateKey = imported;
                }
            };
            btnExportPrivateKey.Click += (s, e) =>
                ExportTextToFile(rtbPrivateKey.Text, "Khóa bí mật (*.priv.xml)|*.priv.xml", "Khóa bí mật");

            btnImportSignature.Click += (s, e) =>
            {
                string imported = ImportTextFromFile("Tệp chữ ký văn bản (*.sig)|*.sig", "Chữ ký văn bản");
                if (!string.IsNullOrEmpty(imported))
                    rtbSignatureText.Text = imported;
            };
            btnExportSignature.Click += (s, e) =>
                ExportTextToFile(rtbSignatureText.Text, "Tệp chữ ký văn bản (*.sig)|*.sig", "Chữ ký văn bản");

            btnImportFileSignature.Click += (s, e) =>
            {
                string imported = ImportTextFromFile("Tệp chữ ký dữ liệu (*.sig)|*.sig", "Chữ ký tệp tin");
                if (!string.IsNullOrEmpty(imported))
                    rtbFileSignature.Text = imported;
            };
            btnExportFileSignature.Click += (s, e) =>
                ExportTextToFile(rtbFileSignature.Text, "Tệp chữ ký dữ liệu (*.sig)|*.sig", "Chữ ký tệp tin");
        }

        // =====================================================
        // TRÌNH XỬ LÝ LƯU VÀ ĐỌC FILE
        // =====================================================
        private void ExportTextToFile(string content, string filter, string dataName)
        {
            if (string.IsNullOrWhiteSpace(content))
            {
                ShowWarning($"Không có dữ liệu [{dataName}] để xuất tệp!", "Xuất thất bại");
                return;
            }
            using SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = filter,
                Title = $"Lưu trữ tệp {dataName}"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(sfd.FileName, content);
                    ShowSuccess($"Xuất dữ liệu [{dataName}] thành công!\nĐường dẫn: {sfd.FileName}");
                }
                catch (Exception ex) { ShowError($"Thao tác xuất tệp thất bại.\n{ex.Message}"); }
            }
        }

        private string ImportTextFromFile(string filter, string dataName)
        {
            using OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = filter,
                Title = $"Chọn tệp dữ liệu {dataName} cần nhập"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string data = File.ReadAllText(ofd.FileName);
                    ShowSuccess($"Nhập dữ liệu [{dataName}] thành công!");
                    return data;
                }
                catch (Exception ex) { ShowError($"Đọc tệp tin thất bại.\n{ex.Message}"); }
            }
            return string.Empty;
        }

        // =====================================================
        // TOGGLE: CHẾ ĐỘ THỦ CÔNG / TỰ ĐỘNG
        // =====================================================
        private void ChkManualKey_CheckedChanged(object sender, EventArgs e)
        {
            ToggleManualKeyControls(chkManualKey.Checked);
        }

        private void ToggleManualKeyControls(bool isManual)
        {
            txtParamP.Enabled = isManual;
            txtParamQ.Enabled = isManual;
            txtParamE.Enabled = isManual;
            btnConfirmKey.Enabled = isManual;
            btnSuggestP.Enabled = isManual;
            btnSuggestQ.Enabled = isManual;

            btnAutoKey.Enabled = !isManual;
            cbKeyLength.Enabled = true;

            pnlManualParams.BackColor = isManual
                ? Color.FromArgb(15, 35, 50)
                : Color.FromArgb(20, 28, 38);
        }

        // =====================================================
        // GỢI Ý SỐ NGUYÊN TỐ
        // =====================================================
        private void BtnSuggestP_Click(object sender, EventArgs e)
            => SuggestPrimeForTextBox(txtParamP, "p");

        private void BtnSuggestQ_Click(object sender, EventArgs e)
            => SuggestPrimeForTextBox(txtParamQ, "q");

        private void SuggestPrimeForTextBox(TextBox targetTextBox, string paramName)
        {
            try
            {
                if (cbKeyLength.SelectedItem == null)
                {
                    ShowWarning("Vui lòng chọn độ dài khóa (Key Length) để tính kích thước số nguyên tố!", "Thiếu cấu hình");
                    return;
                }

                int keySize = Convert.ToInt32(cbKeyLength.SelectedItem);
                int primeBits = keySize / 2;

                Cursor = Cursors.WaitCursor;
                SetStatus($"Đang sinh số nguyên tố {paramName} ({primeBits}-bit)...", StatusType.Processing);

                BigInteger prime = _rsaService.GeneratePrimeForUI(primeBits);
                targetTextBox.Text = prime.ToString();

                Cursor = Cursors.Default;
                SetStatus($"Gợi ý số nguyên tố {paramName} ({primeBits}-bit) thành công!", StatusType.Success);
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                SetStatus($"Lỗi sinh số nguyên tố {paramName}!", StatusType.Error);
                ShowError($"Không thể gợi ý số nguyên tố:\n{ex.Message}");
            }
        }

        // =====================================================
        // XÁC NHẬN SINH KHÓA THỦ CÔNG
        // =====================================================
        private void BtnConfirmKey_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtParamP.Text) ||
                string.IsNullOrWhiteSpace(txtParamQ.Text) ||
                string.IsNullOrWhiteSpace(txtParamE.Text))
            {
                ShowWarning("Vui lòng nhập hoặc dùng nút Gợi Ý để điền đủ p, q và e!", "Thiếu tham số");
                return;
            }

            try
            {
                Cursor = Cursors.WaitCursor;
                SetStatus("Đang tính toán cặp khóa từ tham số p, q, e...", StatusType.Processing);

                if (_rsaService.GenerateKeyPairManual(
                        txtParamP.Text.Trim(),
                        txtParamQ.Text.Trim(),
                        txtParamE.Text.Trim(),
                        out string error))
                {
                    rtbPublicKey.Text = _rsaService.XmlPublicKey;
                    rtbPrivateKey.Text = _rsaService.XmlPrivateKey;

                    Cursor = Cursors.Default;
                    SetStatus("Khởi tạo cặp khóa từ p, q, e thành công!", StatusType.Success);
                    ShowSuccess("Khởi tạo cấu trúc khóa XML từ ba tham số p, q, e thành công!");
                }
                else
                {
                    Cursor = Cursors.Default;
                    SetStatus("Sinh khóa thủ công thất bại!", StatusType.Error);
                    ShowError($"Lỗi kiểm tra dữ liệu RSA:\n{error}");
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                SetStatus("Sinh khóa thất bại — lỗi hệ thống!", StatusType.Error);
                ShowError($"Lỗi tính toán RSA:\n{ex.Message}");
            }
        }

        // =====================================================
        // SINH KHÓA TỰ ĐỘNG
        // =====================================================
        private void BtnAutoKey_Click(object sender, EventArgs e)
        {
            try
            {
                int keySize = Convert.ToInt32(cbKeyLength.SelectedItem);

                Cursor = Cursors.WaitCursor;
                SetStatus($"Đang sinh cặp khóa RSA {keySize}-bit...", StatusType.Processing);

                _rsaService.GenerateKeyPair(keySize);
                rtbPublicKey.Text = _rsaService.XmlPublicKey;
                rtbPrivateKey.Text = _rsaService.XmlPrivateKey;

                Cursor = Cursors.Default;
                SetStatus($"Sinh khóa RSA {keySize}-bit thành công!", StatusType.Success);
                ShowSuccess($"Đã sinh tự động cặp khóa RSA {keySize}-bit.");
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                SetStatus("Sinh khóa tự động thất bại!", StatusType.Error);
                ShowError($"Thao tác sinh khóa gặp lỗi:\n{ex.Message}");
            }
        }

        // =====================================================
        // KÝ VÀ XÁC MINH VĂN BẢN
        // =====================================================
        private void BtnSignText_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbPrivateKey.Text))
            { ShowWarning("Vui lòng nạp hoặc sinh Khóa bí mật trước khi ký!", "Yêu cầu khóa bí mật"); return; }
            if (string.IsNullOrWhiteSpace(txtInputText.Text))
            { ShowWarning("Văn bản gốc đang trống. Nhập nội dung cần ký!", "Thiếu dữ liệu"); return; }

            try
            {
                SetStatus("Đang tạo chữ ký số cho văn bản...", StatusType.Processing);
                _rsaService.XmlPrivateKey = rtbPrivateKey.Text;
                rtbSignatureText.Text = _rsaService.SignData(txtInputText.Text);
                SetStatus("Tạo chữ ký văn bản thành công!", StatusType.Success);
                ShowSuccess("Tạo chữ ký điện tử cho văn bản thành công!");
            }
            catch (Exception ex)
            {
                SetStatus("Ký văn bản thất bại!", StatusType.Error);
                ShowError($"Ký văn bản thất bại:\n{ex.Message}");
            }
        }

        private void BtnVerifyTextSignature_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbPublicKey.Text) ||
                string.IsNullOrWhiteSpace(rtbSignatureText.Text))
            { ShowWarning("Yêu cầu nhập đầy đủ Khóa công khai và Chữ ký!", "Thiếu thông tin"); return; }

            try
            {
                SetStatus("Đang xác minh chữ ký văn bản...", StatusType.Processing);
                _rsaService.XmlPublicKey = rtbPublicKey.Text;
                bool isValid = _rsaService.VerifyData(txtInputText.Text, rtbSignatureText.Text);

                if (isValid)
                {
                    SetStatus("XÁC MINH THÀNH CÔNG — Văn bản toàn vẹn, chữ ký hợp lệ!", StatusType.Success);
                    ShowSuccess("✔  Xác minh thành công!\n\nVăn bản hoàn toàn toàn vẹn và khớp với chữ ký.");
                }
                else
                {
                    SetStatus("XÁC MINH THẤT BẠI — Dữ liệu bị sửa đổi hoặc sai khóa!", StatusType.Error);
                    ShowWarning("⚠  Kiểm tra thất bại.\n\nVăn bản đã bị sửa đổi hoặc sai khóa.", "Chữ ký không hợp lệ");
                }
            }
            catch (Exception ex)
            {
                SetStatus("Lỗi hệ thống khi xác minh!", StatusType.Error);
                ShowError($"Lỗi xác minh:\n{ex.Message}");
            }
        }

        // =====================================================
        // KÝ VÀ XÁC MINH FILE
        // =====================================================
        private void BtnChooseFile_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog { Filter = "Tất cả các tệp (*.*)|*.*" };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = ofd.FileName;
                SetStatus($"Đã chọn file: {Path.GetFileName(ofd.FileName)}", StatusType.Info);
            }
        }

        private void BtnSignFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbPrivateKey.Text) || !File.Exists(txtFilePath.Text))
            { ShowWarning("Đường dẫn file không tồn tại hoặc chưa có Khóa bí mật!", "Lỗi điều kiện"); return; }

            try
            {
                SetStatus($"Đang ký file: {Path.GetFileName(txtFilePath.Text)}...", StatusType.Processing);
                _rsaService.XmlPrivateKey = rtbPrivateKey.Text;

                Cursor = Cursors.WaitCursor;
                rtbFileSignature.Text = _rsaService.SignFile(txtFilePath.Text);
                Cursor = Cursors.Default;

                SetStatus($"Ký file thành công: {Path.GetFileName(txtFilePath.Text)}", StatusType.Success);
                ShowSuccess("Tạo chữ ký số an toàn cho tệp tin thành công!");
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                SetStatus("Ký file thất bại!", StatusType.Error);
                ShowError($"Ký tệp tin thất bại:\n{ex.Message}");
            }
        }

        private void BtnVerifyFileSignature_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbPublicKey.Text) ||
                string.IsNullOrWhiteSpace(rtbFileSignature.Text) ||
                !File.Exists(txtFilePath.Text))
            { ShowWarning("Kiểm tra lại Khóa công khai, tệp tin gốc và mã chữ ký!", "Thiếu điều kiện"); return; }

            try
            {
                SetStatus("Đang xác minh tính toàn vẹn của tệp tin...", StatusType.Processing);
                _rsaService.XmlPublicKey = rtbPublicKey.Text;

                Cursor = Cursors.WaitCursor;
                bool isValid = _rsaService.VerifyFile(txtFilePath.Text, rtbFileSignature.Text);
                Cursor = Cursors.Default;

                if (isValid)
                {
                    SetStatus("XÁC MINH FILE THÀNH CÔNG — Tệp tin toàn vẹn!", StatusType.Success);
                    ShowSuccess("✔  Xác minh tệp tin thành công!\n\nFile toàn vẹn, không bị sửa đổi.");
                }
                else
                {
                    SetStatus("XÁC MINH FILE THẤT BẠI — Nội dung tệp đã bị thay đổi!", StatusType.Error);
                    ShowWarning("⚠  Cảnh báo!\n\nNội dung tệp tin đã bị thay đổi so với chữ ký gốc.", "Xác thực thất bại");
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                SetStatus("Lỗi hệ thống khi xác minh file!", StatusType.Error);
                ShowError($"Lỗi khi xác minh file:\n{ex.Message}");
            }
        }

        // =====================================================
        // HELPER: THÔNG BÁO VÀ TRẠNG THÁI
        // =====================================================
        private enum StatusType { Info, Success, Error, Processing }

        private void SetStatus(string message, StatusType type)
        {
            lblStatusMessage.Text = "  " + message;
            switch (type)
            {
                case StatusType.Success:
                    lblStatusMessage.ForeColor = Color.FromArgb(0, 212, 170);
                    picStatusIcon.BackColor = Color.FromArgb(0, 212, 170);
                    break;
                case StatusType.Error:
                    lblStatusMessage.ForeColor = Color.FromArgb(255, 85, 85);
                    picStatusIcon.BackColor = Color.FromArgb(255, 85, 85);
                    break;
                case StatusType.Processing:
                    lblStatusMessage.ForeColor = Color.FromArgb(100, 180, 255);
                    picStatusIcon.BackColor = Color.FromArgb(100, 180, 255);
                    break;
                default:
                    lblStatusMessage.ForeColor = Color.FromArgb(160, 180, 200);
                    picStatusIcon.BackColor = Color.FromArgb(80, 100, 120);
                    break;
            }
        }

        private void ShowSuccess(string message)
            => MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void ShowWarning(string message, string title = "Cảnh báo")
            => MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);

        private void ShowError(string message)
            => MessageBox.Show(message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}