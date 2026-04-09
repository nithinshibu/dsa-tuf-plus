using System;

public class Solution
{
    /* Function to find the largest odd number 
    that is a substring of given string */
    public string LargeOddNum(string s)
    {
        int last_odd_index = -1;
        
        // Iterate through the string from the end to beginning
        for (int i = s.Length - 1; i >= 0; i--)
        {
            // Break if an odd digit is found
            if ((s[i] - '0') % 2 == 1)
            {
                last_odd_index = i;
                break;
            }
        }
        
        // If no odd digit was found, return an empty string
        if (last_odd_index == -1)
        {
            return "";
        }

        // Skipping any leading zeroes
        int start_index = 0;
        while (start_index <= last_odd_index && s[start_index] == '0')
        {
            start_index++;
        }
        
        // Return the largest odd number substring
        // C# Substring(startIndex, length) where length = (endIndexExclusive) - startIndex
        return s.Substring(start_index, (last_odd_index + 1) - start_index);
    }
}

/* 

Time Complexity: O(N), The loop runs once through the string of length N.

Space Complexity: O(N), The auxiliary space used is O(1) but if the space for returned string is considered (which will be O(N) in the worst case), the overall space complexity comes out to be O(N).

You are not using extra arrays or lists → good ✅
BUT you are creating a new string copy → costs memory ❗

The algorithm uses constant extra space for variables, but since Substring creates a new string of size up to N, the overall space complexity is O(N).

Index:  0 1 2 3 4 5 6 7 8
Chars:  0 0 2 0 3 1 4 3 8

last_odd_index = 7 

Remove leading zeros (start_index)
start_index = 0 → '0'
start_index = 1 → '0'
start_index = 2 → '2' ✅ stop

So , start_index = 2 and last_odd_index = 7 

return s.Substring(start_index, (last_odd_index + 1) - start_index);

IN C# Substring(start, length) , NOT (start, end) , BUT (start, how many characters)

Here , (last_odd_index + 1) used because Substring excludes the end index , endExclusive = last_odd_index + 1 = 7+1 = 8

length = endExclusive - start_index
       = 8 - 2
       = 6

s.Substring(2, 6) means Start at index 2 and Take 6 characters --> "203143"

Substring(start, end) ❌ (not valid in C#)

So convert it to:

Substring(start, end - start) ✅


*/