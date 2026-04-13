using System;

public class Solution
{
    // Function to check if a given string is a palindrome
    public bool palindromeCheck(string s)
    {
        int left = 0;
        int right = s.Length - 1;

        // Iterate while  start pointer is less than  end pointer
        while (left < right)
        {
            // If characters don't match, it's not a palindrome
            if (s[left] != s[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}


