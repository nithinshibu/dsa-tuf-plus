using System;
public class Solution
{
    public bool arraySortedOrNot(int[] arr, int n)
    {
        // Iterate through each element
        for (int i = 0; i < n - 1; i++)
        {
            // Compare with every subsequent element
            for (int j = i + 1; j < n; j++)
            {
                // If any element is out of order, return false
                if (arr[i] > arr[j])
                {
                    return false;
                }
            }
        }
        // All elements are in order
        return true;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        // Creating an instance of solution class
        Solution solution = new Solution();
        int[] arr = { 1, 2, 3, 4, 5 };
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

Complexity Analysis:

Time Complexity: O(N²)
Compare each element with all the elements that come after it. This involves a nested loop: the outer loop runs N times (traversing every single element of the array with N elements) and the inner the loop runs up to N-1 times.


Space Complexity: O(1)
A constant amount of extra space is used because no additional data structures is needed.

 */