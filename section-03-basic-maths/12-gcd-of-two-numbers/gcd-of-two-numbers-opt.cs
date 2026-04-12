using System;

public class Solution
{
    /* Function to find the 
    GCD of two numbers */
    public int GCD(int n1, int n2)
    {

        /* Continue loop as long as both 
         n1 and n2 are greater than zero */
        while (n1 > 0 && n2 > 0)
        {

            /* If n1 is greater than n2, perform 
             modulo operation - n1 % n2 */
            if (n1 > n2)
            {
                n1 = n1 % n2;
            }

            /* Else perform modulo 
            operation - n2 % n1 */
            else
            {
                n2 = n2 % n1;
            }
        }

        // If n1 is zero, GCD is stored in n2
        if (n1 == 0) return n2;

        // else GCD is stored in n1
        return n1;
    }
}




/* 

Time Complexity: O(log(min(N1, N2))) – where N1 and N2 are given numbers. Because in every iteration, the algorithm is dividing larger number with the smaller number resulting in time complexity.(approx.)

Space Complexity: O(1) – Using a couple of variables i.e., constant space.

 */