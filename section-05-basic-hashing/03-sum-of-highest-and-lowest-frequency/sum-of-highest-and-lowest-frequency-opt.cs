public class Solution
{
    public int SumHighestAndLowestFrequency(int[] nums)
    {
        int maxFreq = 0,
            minFreq = nums.Length;
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (map.ContainsKey(nums[i]))
                map[nums[i]]++;
            else
                map[nums[i]] = 1;
        }
        foreach (int freq in map.Values)
        {
            maxFreq = Math.Max(maxFreq, freq);
            minFreq = Math.Min(minFreq, freq);
        }
        return maxFreq + minFreq;
    }
}

/* 

Time Complexity 

* You loop through the array once to build the frequency map → O(n)
* Then you loop through the dictionary values → at most O(n) (if all elements are unique)
* No nested loops, everything is sequential
* So total time = O(n) + O(n)
* Final Time Complexity = O(n)✅

---

Space Complexity 

* You are storing frequencies in a dictionary
* In worst case (all elements different), dictionary stores n entries
* No extra space apart from this map
* So space used grows with input size
* Final Space Complexity = O(n)✅

 */