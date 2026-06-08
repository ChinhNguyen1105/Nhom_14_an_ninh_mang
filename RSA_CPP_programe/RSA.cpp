#include "RSA.h"
#include <cstdlib>
#include <ctime>

long long RSA::gcd(long long a,long long b)
{
    while(b!=0)
    {
        long long t=b;
        b=a%b;
        a=t;
    }

    return a;
}
//hàm lũy thừa modulo
long long RSA::modPow(
    long long base,
    long long exp,
    long long mod)
{
    long long result=1;

    while(exp>0)
    {
        if(exp%2==1)
            result=(result*base)%mod;

        base=(base*base)%mod;

        exp/=2;
    }

    return result;
}
//Hàm Nghịch đảo
long long RSA::modInverse(
    long long a,
    long long m)
{
    for(long long x=1;x<m;x++)
    {
        if((a*x)%m==1)
            return x;
    }

    return -1;
}
//Hàm sinh khóa
void RSA::generateKeys(
    long long p,
    long long q)
{
    this->p=p;
    this->q=q;

    n=p*q;

    phi=(p-1)*(q-1);

    e=3;

    while(gcd(e,phi)!=1)
    {
        e++;
    }

    d=modInverse(e,phi);
}
//Hàm Ký
long long RSA::sign(long long hash)
{
    return modPow(
        hash,
        d,
        n);
}
//Hàm Xác minh
long long RSA::verify(
    long long signature)
{
    return modPow(
        signature,
        e,
        n);
}
//Hàm kiểm tra điều kiện p q
bool RSA::isPrime(long long n)
{
    if(n < 2)
        return false;

    for(long long i = 2;
         i * i <= n;
         i++)
    {
        if(n % i == 0)
            return false;
    }

    return true;
}
//Hàm sinh khóa tự động
long long RSA::generatePrime()
{
    while(true)
    {
        long long num =
            rand() % (5000 - 1000 + 1) + 1000;

        if(isPrime(num))
            return num;
    }
}
