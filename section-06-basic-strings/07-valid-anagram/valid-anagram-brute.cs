using System;

public class Solution
{
    public bool anagramStrings(string s, string t)
    {
        // If lengths are not equal, they cannot be anagrams
        if (s.Length != t.Length)
        {
            return false;
        }

        // Convert strings to char arrays
        char[] sChars = s.ToCharArray();
        char[] tChars = t.ToCharArray();

        // Sort both char arrays
        Array.Sort(sChars);
        Array.Sort(tChars);

        // Convert sorted char arrays back to strings and compare
        string sortedS = new string(sChars);
        string sortedT = new string(tChars);

        return sortedS.Equals(sortedT);
    }

    
}


/* 

---Python version---
class Solution:
    def anagramStrings(self, s, t):
        # If lengths are not equal, they cannot be anagrams
        if len(s) != len(t):
            return False
        
        # Sort both strings and compare
        return sorted(s) == sorted(t)

Time Complexity: O(N log N) due to sorting each string.

Space Complexity: The space complexity will be O(N) due to the use of sorted() function, which creates a new string to hold the sorted string.



*/