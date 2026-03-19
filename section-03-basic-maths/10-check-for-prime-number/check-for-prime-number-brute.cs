using System;

class Solution
{
    /* Function to find whether the
    number is prime or not */
    public bool IsPrime(int n)
    {
        // Edge case
        if (n < 2) return false;
        
        // Loop from 2 to n-1
        for (int i = 2; i < n; ++i)
        {
            // Check if i is a divisor
            if (n % i == 0)
            {
                return false;
            }
        }
        
        // Return true as the number is prime
        return true;
    }
}

class Program
{
    static void Main()
    {
        int n = 5;
        
        /* Creating an instance of 
        Solution class */
        Solution sol = new Solution();
        
        /* Function call to find whether the
         given number is prime or not */
        bool ans = sol.IsPrime(n);
        
        if (ans)
        {
            Console.WriteLine($"{n} is a prime number.");
        }
        else
        {
            Console.WriteLine($"{n} is not a prime number.");
        }
    }
}


/* 
Time Complexity: O(N) – Looping N times to find the count of all divisors of N.

Space Complexity: O(1) – Using a couple of variables i.e., constant space.
 */