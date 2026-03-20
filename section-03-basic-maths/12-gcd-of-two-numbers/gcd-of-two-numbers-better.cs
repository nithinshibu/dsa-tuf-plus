using System;

public class Solution
{
    /* Function to find the
    GCD of two numbers */
    public int GCD(int n1, int n2)
    {
        // Variable to store the gcd
        int gcd = 1;
        
        // Iterate from 1 to min(n1, n2)
        for (int i = Math.Min(n1, n2); i >= 1; --i)
        {
            /* Check if i is a common
            divisor of both n1 and n2 */
            if (n1 % i == 0 && n2 % i == 0)
            {
                // Update gcd
                gcd = i;
                // Break to skip unnecessary iterations
                break;
            }
        }
        
        // Return stored GCD.
        return gcd;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Input numbers
        Console.Write("Enter first number (n1): ");
        int n1 = int.Parse(Console.ReadLine());
        
        Console.Write("Enter second number (n2): ");
        int n2 = int.Parse(Console.ReadLine());

        /* Creating an instance of 
        Solution class */
        Solution sol = new Solution();

        /* Function call to find the
        gcd of two numbers */
        int ans = sol.GCD(n1, n2);

        Console.WriteLine($"GCD of {n1} and {n2} is: {ans}");
    }
}


/* 
Complexity Analysis:
Time Complexity: O(min(N1, N2)) – where N1 and N2 are given numbers. In the worst case, finding GCD will require iterating from min(N1, N2) till 1 and performing constant time operations in each iteration.

Space Complexity: O(1) – Using a couple of variables i.e., constant space.
 */