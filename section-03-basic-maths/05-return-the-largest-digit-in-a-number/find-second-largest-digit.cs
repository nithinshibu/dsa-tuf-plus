using System;

public class Solution
{
    public int SecondLargestDigit(int n)
    {
        n = Math.Abs(n); // handle negative numbers

        int largest = -1;
        int secondLargest = -1;

        while (n > 0)
        {
            int digit = n % 10;

            if (digit > largest)
            {
                secondLargest = largest;
                largest = digit;
            }
            else if (digit != largest && digit > secondLargest)
            {
                secondLargest = digit;
            }

            n = n / 10;
        }

        return secondLargest;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        int n = 6678;

        Solution sol = new Solution();
        int result = sol.SecondLargestDigit(n);

        Console.WriteLine("Second largest digit: " + result);
    }
}