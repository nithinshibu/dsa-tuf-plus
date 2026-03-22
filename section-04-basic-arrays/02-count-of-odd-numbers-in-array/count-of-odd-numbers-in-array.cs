using System;

public class Solution
{
    // Function to count the odd numbers in an array 
    public int countOdd(int[] arr, int n)
    {
        int count = 0;
        // Iterate through the array
        for (int i = 0; i < n; i++)
        {
            // Check for odd values and increment
            if (arr[i] % 2 != 0)
            {
                count++;
            }
        }
        return count;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Creating an instance of Solution class
        Solution sol = new Solution();
        int[] arr = { 1, 2, 3, 4, 5 };
        int n = arr.Length;

        // Function to count the odd numbers in an array
        int count = sol.countOdd(arr, n);
        Console.WriteLine("Count of odd numbers: " + count);
    }
}


/* 

Time Complexity : O(N)
Each element in the array has to be inspected once to determine if it's odd, resulting in a linear time complexity where N is the number of elements in the array.

Space Complexity : O(1)
The space used is constant, as we only use a single counter regardless of the size of the input array.

 */