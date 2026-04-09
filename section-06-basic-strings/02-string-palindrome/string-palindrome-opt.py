class Solution:
    # Function to check if a given string is a palindrome
    def palindromeCheck(self, s):
        left = 0               
        right = len(s) - 1     

        # Iterate while  start pointer is less than end pointer
        while left < right:
            # If characters  don't match, it's not a palindrome
            if s[left] != s[right]:
                return False
            left += 1  
            right -= 1  
        return True 




""" 
Time Complexity: O(N), where n is the length of the string.

Space Complexity: O(1), as no extra space is required.

"""