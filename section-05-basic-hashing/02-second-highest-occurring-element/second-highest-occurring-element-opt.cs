public class Solution
{
    public int SecondMostFrequentElement(int[] nums)
    {
        int maxFreq = -1,
            maxElement = -1,
            secHighestFreq = -1,
            secHighestElement = -1;
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (map.ContainsKey(nums[i]))
            {
                map[nums[i]]++;
            }
            else
            {
                map[nums[i]] = 1;
            }
        }
        foreach (KeyValuePair<int, int> entry in map)
        {
            int freq = entry.Value,
                ele = entry.Key;
            if (maxFreq < freq)
            {
                secHighestElement = maxElement;
                secHighestFreq = maxFreq;
                maxFreq = freq;
                maxElement = ele;
            }
            else if (freq == maxFreq)
            {
                maxElement = Math.Min(maxElement, ele);
            }
            else if (freq > secHighestFreq)
            {
                secHighestElement = ele;
                secHighestFreq = freq;
            }
            else if (freq == secHighestFreq)
            {
                secHighestElement = Math.Min(secHighestElement, ele);
            }
        }
        return secHighestElement;
    }
}


/* 

Time Complexity

You loop through the array once to build the frequency map → O(n).
Then you loop through the dictionary to find the max and second max frequencies → O(n) in worst case.
These are two separate linear passes.
Constants are ignored in Big-O notation.
Final Time Complexity = O(n)

Space Complexity

You use a dictionary to store frequencies of elements.
In the worst case, all elements are unique, so the dictionary stores n entries.
Other variables use only constant space.
So the dominant space comes from the dictionary.
Final Space Complexity = O(n)

 */