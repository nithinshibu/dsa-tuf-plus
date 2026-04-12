using System;

public class Solution
{
    /* Function to find the
    factorial of a number */
    public int Factorial(int n)
    {
        // Edge case
        if (n == 0) return 1;

        // Variable to store the factorial
        int fact = 1;

        // Iterate from 1 to n
        for (int i = 1; i <= n; i++)
        {
            // Multiply fact with current number
            fact = fact * i;
        }

        // Return the factorial stored
        return fact;
    }
}

