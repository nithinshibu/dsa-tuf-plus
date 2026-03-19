class Solution
{
    public bool isPrime(int n)
    {
        if (n < 2)
            return false;
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    public int primeUptoN(int n)
    {
        int cnt = 0;
        for (int i = 2; i <= n; i++)
        {
            if (this.isPrime(i))
                cnt++;
        }
        return cnt;
    }
}

/* 
Time Complexity
O(n * sqrt(n)) where n is the input integer; the outer loop runs from 2 to n, and the inner loop (isPrime) runs up to sqrt(i) for each i.
Space Complexity
O(1) as only a constant amount of extra space is used for variables (cnt, i) regardless of the input size.
 */