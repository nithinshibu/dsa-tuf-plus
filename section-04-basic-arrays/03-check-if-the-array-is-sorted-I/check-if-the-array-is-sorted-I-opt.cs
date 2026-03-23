using System;

public class Program
{
    public class Solution
    {
        // Function to check if an array is sorted
        public bool arraySortedOrNot(int[] arr, int n)
        {
            // Iterate through the array
            for (int i = 0; i < n - 1; i++)
            {
                // Compare each element with the next one
                if (arr[i] > arr[i + 1])
                {
                /* If any element is greater than the next one,
                the array is not sorted */
                    return false;
                }
            }

            // If no such pair is found, array is sorted
            return true;
        }
    }

    public static void Main(string[] args)
    {
        // Driver code
        // Creating an instance of solution class
        Solution solution = new Solution();
        int[] arr = {1, 2, 3, 4, 5};
        int n = arr.Length;

        // Function call to check if the array is sorted
        bool sorted = solution.arraySortedOrNot(arr, n);
        if (sorted)
        {
            Console.WriteLine("Array is sorted.");
        }
        else
        {
            Console.WriteLine("Array is not sorted.");
        }
    }
}

/* 

Time Complexity: O(N)
Perform a single traversal through the array, making a constant-time comparison for each element.

Space Complexity: O(1)
A constant amount of extra space for variables is used, independent of the input size.

 */