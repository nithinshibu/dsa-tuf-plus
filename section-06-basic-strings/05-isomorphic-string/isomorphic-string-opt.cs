using System;

public class Solution
{
    public bool isomorphicString(string s, string t)
    {
        // Arrays to store the last seen positions of characters in s and t
        // C# arrays of value types (like int) are initialized to their default value (0 for int)
        int[] m1 = new int[256];
        int[] m2 = new int[256];
        
        // Length of the string
        int n = s.Length;
        
        // Iterate through each character in the strings
        for (int i = 0; i < n; ++i)
        {
            // If the last seen positions of the current characters don't match, return false
            // s[i] and t[i] are chars, which can be implicitly cast to int for array indexing
            if (m1[s[i]] != m2[t[i]])
            {
                return false;
            }
            
            // Update the last seen positions
            // Using i + 1 to differentiate from the default 0 value (not seen yet)
            m1[s[i]] = i + 1;
            m2[t[i]] = i + 1;
        }
        
        // If all characters match, return true
        return true;
    }
}

/* 
int[] m1 = new int[256];
256 represents the total number of possible ASCII characters.

Why use an array of size 256?

Because:

Every possible character can be used as an index
You get O(1) lookup time (super fast)
No need for dictionaries or hashing


--- Time Complexity: O(N)  ---

We loop through the string only once from start to end.
For each character, we do constant time work (array access).
No nested loops or repeated work.
So total time grows linearly with input size.
👉 If string doubles → time roughly doubles.

--- Space Complexity: O(1) (or O(k)) ---

We use two arrays of size 256, which is fixed.
This size does not change with input length.
Whether string is small or huge → memory stays same.
That’s why it's called constant space (O(1)).
👉 O(k) just means fixed character set size (like ASCII).

*/