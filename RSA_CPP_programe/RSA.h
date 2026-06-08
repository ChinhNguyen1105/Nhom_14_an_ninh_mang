#ifndef RSA_H
#define RSA_H

class RSA
{
public:
    long long p;
    long long q;

    long long n;
    long long phi;

    long long e;
    long long d;

    long long gcd(long long a,long long b);

    long long modPow(
        long long base,
        long long exp,
        long long mod);

    long long modInverse(
        long long a,
        long long m);

    void generateKeys(
        long long p,
        long long q);

    long long sign(long long hash);

    long long verify(long long signature);

    bool isPrime(long long n);

    long long generatePrime();
};

#endif