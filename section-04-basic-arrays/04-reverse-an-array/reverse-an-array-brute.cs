using System;

class Solution {
    // Function to reverse array using an auxiliary array
    public void reverse(int[] arr, int n) {
        int[] copy_arr = new int[n];
        
        /* Fill new array with elements of 
        original array in reverse order */
        for (int i = n - 1; i >= 0; i--) {
            copy_arr[n - i - 1] = arr[i];
        }
        
        // Copy the elements back to the original array
        for (int i = 0; i < n; i++) {
            arr[i] = copy_arr[i];
        }
        
        // Return
        return;
    }
    // Function to print array
    public void PrintArray(int[] arr, int n) {
        for (int i = 0; i < n; i++) {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

}


class Program {
    static void Main() {
        int n = 5;
        int[] arr = {5, 4, 3, 2, 1};
        
        // Creating instance of Solution class
        Solution solution = new Solution();
        Console.Write("Original array: ");
        PrintArray(arr, n);
        
        // Function call to reverse the array 
        solution.reverse(arr, n); 
        Console.Write("Reversed array: ");
        PrintArray(arr, n);
    }
}

/* 
Complexity Analysis:
Time Complexity: O(N), A single-pass of the array with N elements is being done to reverse the array.

Space Complexity: O(N), for the extra array of the same size used.
 */