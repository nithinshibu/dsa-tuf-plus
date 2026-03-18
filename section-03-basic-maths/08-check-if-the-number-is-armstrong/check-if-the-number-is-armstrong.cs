using System;

public class Solution
{
    /* Function to count the 
    number of digits in N */
    public int countDigit(int n)
    {
        if (n == 0) return 1;
        int count = (int)Math.Floor(Math.Log10(n)) + 1;
        return count;
    }

    /* Function to find whether the
    number is Armstrong or not */
    public bool isArmstrong(int n)
    {
        // Store the count of digits
        int count = this.countDigit(n);
        
        // Variable to store the sum
        long sum = 0; // Use long to prevent potential overflow
        
        // Variable to store the copy
        int copy = n;
        
        /* Iterate through each
        digit of the number */
        int tempN = n; // Use a temporary variable to iterate
        while (tempN > 0)
        {
            // Extract the last digit
            int lastDigit = tempN % 10;
            
            // Update sum
            sum += (long)Math.Pow(lastDigit, count);
            
            /* Remove the last digit
             from the number */
            tempN /= 10;
        }
        
        /* Check if the sum of digits raised to the
        power of k equals the original number */
        if (sum == copy) return true;
        return false;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Main function
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        // Creating an instance of 
        // Solution class
        Solution sol = new Solution();

        /* Function call to find whether the
        given number is Armstrong or not */
        bool ans = sol.isArmstrong(n);

        if (ans)
        {
            Console.WriteLine($"{n} is an Armstrong number.");
        }
        else
        {
            Console.WriteLine($"{n} is not an Armstrong number.");
        }
    }
}