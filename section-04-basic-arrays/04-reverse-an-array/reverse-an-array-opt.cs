using System;

class Solution
{
    // Function to reverse array using two pointers
    public void reverse(int[] arr, int n)
    {
        int p1 = 0, p2 = n - 1;
        /* Swap elements pointed by p1 and p2 
        until they meet in the middle */
        while (p1 < p2)
        {
            int tmp = arr[p1];
            arr[p1] = arr[p2];
            arr[p2] = tmp;
            p1++;
            p2--;
        }
        // Return
        return;
    }
    // Function to print array
    public void PrintArray(int[] arr, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

}



/* 

Time Complexity: O(N), A single-pass of the array with N elements is being done to reverse the array

Space Complexity: O(1), no extra data structure is being used so no extra space.

 */