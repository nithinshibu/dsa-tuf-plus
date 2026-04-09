using System;

public class Solution {
    // Function to check if a given string is a palindrome
    public bool palindromeCheck(string s) {
        int left = 0;            
        int right = s.Length - 1; 

        // Iterate while  start pointer is less than  end pointer
        while (left < right) {
            // If characters don't match, it's not a palindrome
            if (s[left] != s[right]) {
                return false;
            }
            left++;   
            right--;  
        }
        return true;  
    }
}

// Main function to test the palindromeCheck method
public class Program {
    public static void Main(string[] args) {
        Solution solution = new Solution();
        string str = "racecar";  

        if (solution.palindromeCheck(str)) {
            Console.WriteLine($"{str} is a palindrome.");
        } else {
            Console.WriteLine($"{str} is not a palindrome.");
        }
    }
}
