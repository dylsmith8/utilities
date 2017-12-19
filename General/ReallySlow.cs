// use if want to slow down an area for testing purposes :) 
public void Slow()
{
    long nthPrime = GetPrime(100000);
}

public long GetPrime(int n)
{
    int count = 0;
    long a = 2;
    while (count < n)
    {
        long b = 2;
        int prime = 1;
        while (b * b <= a)
        {
            if (a % b == 0)
            {
                prime = 0;
                break;
            }
            b++;
        }
        if (prime > 0)
        {
            count++;
        }
        a++;
    }
    return (--a);
}