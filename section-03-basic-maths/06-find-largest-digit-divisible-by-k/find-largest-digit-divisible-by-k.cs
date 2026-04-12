using System;

public class Solution
{
    public int LargestDigitDivisibleByK(int n, int k)
    {
        n = Math.Abs(n); // handle negative numbers

        int result = -1; // default if no digit found

        while (n > 0)
        {
            int digit = n % 10;

            if (digit % k == 0)
            {
                if (digit > result)
                {
                    result = digit;
                }
            }

            n = n / 10;
        }

        return result;
    }
}

