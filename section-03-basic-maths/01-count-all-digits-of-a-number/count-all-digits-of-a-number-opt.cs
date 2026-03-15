using System;

public class Solution {
    /* Function to count the 
    number of odd digits in N */
    public int countDigit(int n) {
        // Edge case
        if (n == 0) return 1;
        
        int count = (int)Math.Floor(Math.Log10(n) + 1);
        return count;
    }
}

public class Program {
    public static void Main(string[] args) {
        // Input number
        int n = 6678;

        // Creating an instance of Solution class
        Solution sol = new Solution();

        // Function call to get count of digits in n
        int ans = sol.countDigit(n);
        Console.WriteLine("The count of digits in the given number is: " + ans);
    }
}