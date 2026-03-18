using System;

public class Solution
{
    /* Function to find whether the
    number is perfect or not */
    public bool IsPerfect(int n)
    {
        /* Variable to store the sum
        of all proper divisors */
        int sum = 0;

        // Loop from 1 to n
        for (int i = 1; i < n; ++i)
        {
            // Check if i is a proper divisor
            if (n % i == 0)
            {
                // Update sum
                sum = sum + i;
            }
        }

        // Compare sum and n
        return sum == n;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Input number
        int n = 6;

        // Creating an instance of Solution class
        Solution sol = new Solution();

        // Function call to find whether the given number is perfect or not
        bool ans = sol.IsPerfect(n);

        if (ans)
        {
            Console.WriteLine($"{n} is a perfect number.");
        }
        else
        {
            Console.WriteLine($"{n} is not a perfect number.");
        }
    }
}

/*

A number is perfect if:

sum of its proper divisors = number itself

Example:

n = 6
Divisors → 1, 2, 3
Sum = 6 → Perfect


Brute force logic - Check all numbers from 1 to n-1

Time Complexity: O(N) – Running a loop from 1 to N.

Space Complexity: O(1) – Using a couple of variables i.e., constant space, regardless of the size of input.

*/

