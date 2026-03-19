using System;

public class Solution
{
    // Function to find whether the
    // number is prime or not
    public bool isPrime(int n)
    {
        
        // Variable to store the 
        // count of divisors of n
        int count = 0;
        
        // Loop from 1 to n
        for (int i = 1; i <= n; ++i)
        {
            
            // Check if i is a divisor
            if (n % i == 0)
            {
                // Increment count
                count = count + 1;
            }
        }
        
        // If count is 2, n is prime
        if (count == 2) return true;
        // Else not prime
        return false;
    }
    
    // Function to find count
    // of primes till n
    public int primeUptoN(int n)
    {
        
        // Variable to store count
        int count = 0;
        
        // Iterate from 2 to n
        for (int i = 2; i <= n; i++)
        {
            
            // Check if i is prime
            if (this.isPrime(i)) count++;
        }
        
        // Return the count
        return count;
    }

    public static void Main(string[] args)
    {
        // Input number
        int n = 6;

        // Creating an instance of Solution class
        Solution sol = new Solution();

        // Function call to get count of all primes till n
        int ans = sol.primeUptoN(n);

        Console.WriteLine("The count of primes till " + n + " is: " + ans);
    }
}


/* 

Time Complexity
O(n^2) explanation: The outer loop in primeUptoN runs n-1 times. For each iteration, the inner function isPrime runs a loop from 1 up to i, resulting in the summation of i from 2 to n, which is O(n(n+1)/2 - 1) = O(n^2).
Space Complexity
O(1) explanation: The algorithm uses a fixed number of integer variables (count, i) regardless of the input size, satisfying constant space complexity.

 */