using System;

public class Solution
{
    /* Function to get the highest 
    occurring element in array nums */
    public int mostFrequentElement(int[] nums)
    {
        
        // Variable to store the size of array
        int n = nums.Length;
        
        // Variable to store maximum frequency
        int maxFreq = 0; 
        
        /* Variable to store element 
        with maximum frequency */
        int maxEle = 0;
        
        // Visited array
        bool[] visited = new bool[n];
        
        // First loop
        for (int i = 0; i < n; i++) {
            // Skip second loop if already visited
            if (visited[i]) continue;
            
            /* Variable to store frequency
            of current element */
            int freq = 0;
            
            // Second loop
            for (int j = i; j < n; j++) {
                if (nums[i] == nums[j]) {
                    freq++;
                    visited[j] = true;
                }
            }
            
            /* Update variables if new element having 
            highest frequency is found */
            if (freq > maxFreq) {
                maxFreq = freq;
                maxEle = nums[i];
            } else if (freq == maxFreq) {
                maxEle = Math.Min(maxEle, nums[i]);
            }
        }
        
        // Return the result
        return maxEle;
    }
}            
public class Program
{
    public static void Main(string[] args)
    {
        // Input array
        int[] nums = { 4, 4, 5, 5, 6 };

        // Creating an instance of Solution class
        Solution sol = new Solution();

        /* Function call to get the
highest occurring element in array nums */
        int ans = sol.mostFrequentElement(nums);

        Console.WriteLine("The highest occurring element in the array is: " + ans);
    }
}

/* 

Complexity Analysis:
Time Complexity: O(N2) (where N is the size of the array given) – Using two nested loops.

Space Complexity: O(N) – Using a visited array of size N and a couple of variables.

 */