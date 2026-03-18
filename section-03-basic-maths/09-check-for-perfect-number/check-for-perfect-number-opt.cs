using System;

public class Solution {
    /* Function to find whether the
    number is perfect or not */
    public bool IsPerfect(int n) {
        // Edge case
        if (n == 1)
            return false;
            
        /* Variable to store the sum
        of all proper divisors */
        long sum = 0;
        
        // Loop from 1 to square root of n
        for (int i = 1; (long)i * i <= n; ++i) {
            
            // Check if i is a proper divisor
            if (n % i == 0) {
                // Update sum
                sum = sum + i;
                
                /* Add the counterpart divisor
                if it's different from i and
                if it is not n itself */
                if (i != 1 && (long)i * i != n) {
                    sum = sum + (n / i);
                }
            }
        }
        
        // Compare sum and n
        if (sum == n) return true;
        return false;
    }
}

public class Program {
    public static void Main(string[] args) {
        int n = 6;

        /* Creating an instance of 
        Solution class */
        Solution sol = new Solution();

        /* Function call to find whether the
        given number is perfect or not */
        bool ans = sol.IsPerfect(n);

        if (ans) {
            Console.WriteLine($"{n} is a perfect number.");
        } else {
            Console.WriteLine($"{n} is not a perfect number.");
        }
    }
}