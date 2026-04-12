using System.Linq;
public class Solution
{
    public List<char> FrequencySort(string s)
    {
        Dictionary<char, int> freq = new Dictionary<char, int>();

        // Count frequencies
        foreach (char c in s)
        {
            if (!freq.ContainsKey(c))
                freq[c] = 0;

            freq[c]++;
        }

        // Sort based on conditions
        return freq
            .OrderByDescending(x => x.Value)
            .ThenBy(x => x.Key)
            .Select(x => x.Key)
            .ToList();
    }
}


/* 

Time Complexity:

* Counting frequency → O(n)
* Sorting unique characters → O(k log k)
* Building result → O(k)

Final Time: O(n + k log k)

Space Complexity:

* Dictionary stores k characters → O(k)
* Result list → O(k)

Final Space: O(k)

Where:
n = length of string
k = number of unique characters


*/