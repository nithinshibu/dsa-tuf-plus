using System;

public class Solution
{
    /* Function to check if a 
    number is palindrome or not */
    public bool IsPalindrome(int n)
    {
        // Create a copy of original number
        int copy = n;

        /* After the code, revNum will
        contain the reversed number */
        int revNum = 0;

        /* Keep on iterating while there
        are digits left to extract */
        while (n > 0)
        {
            int lastDigit = n % 10;

            /* Pushing last digit at the
            back of reversed number */
            revNum = (revNum * 10) + lastDigit;
            n = n / 10; // Integer division
        }

        /* Return true if the reversed and 
        copy of original number is same */
        return revNum == copy;
    }
}
