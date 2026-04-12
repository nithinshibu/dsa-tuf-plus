using System;

public class Solution
{
    // Function to get the sum of array elements
    public int sum(int[] arr, int n)
    {
        int ans = 0; // to store the answer

        // Iterate on all the elements
        for (int i = 0; i < n; i++)
        {
            // Add the current element to the sum
            ans = ans + arr[i];
        }

        // Return the result
        return ans;
    }
}




/* 

Complexity Analysis
Time Complexity : O(N), because each element in the array is processed exactly once.
Space Complexity : O(1), because only couple of variable are used.

 */