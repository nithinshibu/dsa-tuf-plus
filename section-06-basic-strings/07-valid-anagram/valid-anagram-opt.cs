using System;

public class Solution
{
    public bool anagramStrings(string s, string t)
    {
        // Edge Cases
        if (s.Length != t.Length) return false;

        // To store the count of each character
        int[] count = new int[26]; // Initializes to all zeros by default

        // Count occurrence of each character in first string 
        foreach (char c in s)
        {
            count[c - 'a']++;
        }

        // Decrement the count for each character in the second string
        foreach (char c in t)
        {
            count[c - 'a']--;
        }

        // Check for count of every character
        foreach (int i in count)
        {
            // If the count is not zero
            if (i != 0) return false; // Return false
        }

        // Otherwise strings are anagram
        return true;
    }
}

