public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string prefix = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(prefix) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (prefix == "")
                    return "";
            }
        }
        return prefix;
    }
}

/* 

 We start by assuming the first string is the common prefix.
 Why? Because the common prefix must be something that exists in ALL strings.
 So we take the entire first string as a "best case" starting point.
string prefix = strs[0];

 Now we compare this prefix with every other string one by one.
for (int i = 1; i < strs.Length; i++)
{
     This while loop keeps shrinking the prefix
     until it becomes a valid prefix of the current string strs[i].
    
     IndexOf(prefix) checks where 'prefix' appears inside strs[i].
     If it returns 0 → prefix is at the START → valid prefix ✅
     If it returns anything else (-1 or >0) → not a prefix ❌
    while (strs[i].IndexOf(prefix) != 0)
    {
         If prefix is not matching from the start,
         we remove the LAST character from prefix.
         This reduces the prefix size step by step.
        
         Example:
         prefix = "flower"
         becomes "flowe" → "flow" → "flo" → "fl" ...
        prefix = prefix.Substring(0, prefix.Length - 1);

         If prefix becomes empty, it means:
         there is NO common prefix at all among the strings.
         So we can immediately return "".
        if (prefix == "") return "";
    }

     If we exit the while loop,
     it means current string contains the prefix at the start.
     So we move to the next string and repeat the process.
}

 After checking all strings,
 whatever remains in 'prefix' is the longest common prefix.
return prefix;


⏱️ Time Complexity — O(N × M)
You iterate through all N strings using the for loop.
For each string, the while loop may shrink the prefix up to M times (M = length of prefix/string).
Inside that, IndexOf(prefix) itself can take up to O(M) → so overall worst case becomes O(N × M²), but commonly simplified as O(N × M).
📦 Space Complexity — O(1) (constant space)
You are not using any extra data structures (no arrays, maps, etc.).
The prefix string is reused and shrunk, not duplicated significantly.
So extra memory used does not grow with input size → O(1).


 */