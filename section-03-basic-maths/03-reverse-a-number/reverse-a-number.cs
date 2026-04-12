using System;

public class Solution
{
    // Function to reverse given number n
    public int ReverseNumber(int n)
    {
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
            n = n / 10;
        }

        return revNum;
    }
}

