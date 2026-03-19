using System;

class Solution
{
    /* Function to find whether the
    number is prime or not */
    public bool IsPrime(int n)
    {
        // Edge case
        if (n < 2) return false;
        
        // Loop from 2 to sqrt(n)
        for (int i = 2; i * i <= n; ++i)
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

Time Complexity: O(sqrt(N)) – Looping sqrt(N) times to find the count of all divisors of N.

Space Complexity: O(1) – Using a couple of variables i.e., constant space.

 */