using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    /* Function to get the highest
    occurring element in array n */
    public int mostFrequentElement(int[] nums)
    {
        // Variable to store the size of array
        int n = nums.Length;

        // Variable to store maximum frequency
        int maxFreq = 0;

        // Variable to store element
        // with maximum frequency
        int maxEle = 0;

        // Dictionary (equivalent to HashMap/Map)
        Dictionary<int, int> mpp = new Dictionary<int, int>();

        // Iterating on the array
        for (int i = 0; i < n; i++)
        {
            // Updating dictionary
            if (mpp.ContainsKey(nums[i]))
            {
                mpp[nums[i]]++;
            }
            else
            {
                mpp[nums[i]] = 1;
            }
        }

        // Iterate on the map
        foreach (KeyValuePair<int, int> entry in mpp)
        {
            int ele = entry.Key;
            int freq = entry.Value;

            if (freq > maxFreq)
            {
                maxFreq = freq;
                maxEle = ele;
            }
            else if (freq == maxFreq)
            {
                maxEle = Math.Min(maxEle, ele);
            }
        }

        // Return the result
        return maxEle;
    }
}




/* 

Time Complexity: O(N) (where N is the size of the array given) –

Using a single loop, performing insertion, updation opertion on HashMap takes O(1) TC resulting in O(N) TC.
Iterating on HashMap, will take O(N) in the worst-case
Space Complexity: O(N) – In the worst-case scenario, the HashMap will store all the elements in the array when array elements are unique.

 */