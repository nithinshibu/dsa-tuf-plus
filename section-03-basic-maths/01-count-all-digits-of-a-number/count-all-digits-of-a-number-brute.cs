using System;

public class Solution
{
    // Function to count all digits in n
    public int countDigit(int n)
    {
        // Edge case
        if (n == 0) return 1;

        // Set counter to 0
        int cnt = 0;

        // Iterate until n is greater than zero
        while (n > 0)
        {
            // Increment count of digits
            cnt = cnt + 1;
            n = n / 10;
        }

        return cnt;
    }

    public static void Main(string[] args)
    {
        // Input number
        int n = 6678;

        /* Creating an instance of
        Solution class */
        Solution sol = new Solution();

        // Function call to get count of digits in n
        int ans = sol.countDigit(n);
        Console.WriteLine("The count of digits in the given number is: " + ans);
    }
}