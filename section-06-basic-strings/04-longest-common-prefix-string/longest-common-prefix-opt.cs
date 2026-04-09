using System;
using System.Linq;
using System.Text;

public class Solution
{
    // Method to find the longest common prefix in an array of strings
    public string LongestCommonPrefix(string[] strs)
    {
        // Edge case: empty array
        if (strs.Length == 0) return "";

        // Sort the array to get the lexicographically smallest and largest strings
        Array.Sort(strs);
        // First string (smallest in sorted order)
        string first = strs[0];
        // Last string (largest in sorted order)
        string last = strs[strs.Length - 1];
        
        string commonPrefix = "";
        
        // Compare characters of the first and last strings
        for (int i = 0; i < Math.Min(first.Length, last.Length); i++)
        {
            // If characters don't match, return the current prefix
            if (first[i] != last[i])
            {
                return commonPrefix;
            }
            // Append the matching character to the result
            commonPrefix += first[i];
        }
        
        // Return the longest common prefix found
        return commonPrefix;
    }
}

/* 

Time Complexity: O(N * M * log N), where N is the number of strings and M is the maximum length of a string.
The sorting operation takes O(N * M * log N) time because:

Comparing two strings during sort costs up to O(M) (character-by-character comparison).
Sorting does O(N*logN) comparisons.

and the comparison of characters in the first and last strings takes O(M) time, which is dominated by the sorting step making the overall time complexity as O(N * M * logN).
Space Complexity: O(M), as the ans variable can store the length of the prefix which in the worst case will be O(M).

⏱️ Time Complexity (O(N * M * log N))
You have N strings in the array.
You are using Array.Sort(strs) → sorting takes N log N comparisons.
Each comparison between two strings is not constant time.
Why? Because strings are compared character by character, up to M length.
So, one comparison = O(M) in worst case.
Combine with Sorting
Total comparisons in sorting = N log N
Each comparison = O(M)
👉 Total work = (N log N) * M = O(N * M * log N)
Total sorting cost = O(N log N * M) → written as O(N * M * log N).
After sorting, you only compare first and last string.
That comparison loop runs at most M times.
So that part = O(M).
Final complexity = O(N * M * log N + M) → dominated by sorting → O(N * M * log N).

🧠 Space Complexity (O(M))
You are not using extra data structures like arrays or maps.
Sorting happens in-place (no major extra memory counted here).
The only extra memory is commonPrefix.
In worst case, all strings are same → prefix length = M.
So commonPrefix can store up to M characters.
Hence space used = O(M).
Temporary variables (first, last, i) take constant space O(1).
No recursion or stack usage here.
So total space = O(M).


 */