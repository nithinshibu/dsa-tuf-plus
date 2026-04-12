using System;

public class Solution
{
    /* Function to find the largest
    digit in a given number */
    public int LargestDigit(int n)
    {
        // Variable to store the largest digit
        int largestDigit = 0;

        /* Keep on iterating while there
        are digits left to extract */
        while (n > 0)
        {
            int lastDigit = n % 10;

            /* If the current digit is greater than 
            largest digit, update largest digit */
            if (lastDigit > largestDigit)
            {
                largestDigit = lastDigit;
            }

            n /= 10; // Integer division in C# automatically floors for positive integers
        }

        // Return the largest digit
        return largestDigit;
    }
}

