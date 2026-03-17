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

public class Program
{
    public static void Main(string[] args)
    {
        int n = 6678;
        int k = 3;

        Solution sol = new Solution();
        int ans = sol.LargestDigitDivisibleByK(n, k);

        Console.WriteLine("Largest digit divisible by k: " + ans);
    }
}