class Solution:
    def reverseString(self, s):
        # your code goes here
        left = 0
        right = len(s) - 1
        while left < right:
            tmp = s[left]
            s[left] = s[right]
            s[right] = tmp
            left += 1
            right -= 1


""" 
Cleaner version 

class Solution: 
    def reverseString(self, s):
        left, right = 0, len(s) - 1
        
        while left < right:
            s[left], s[right] = s[right], s[left]
            left += 1
            right -= 1

Time Complexity O(N) - Linear time complexity, where n is the length of the string. The algorithm iterates through half of the string.

SpaceComplexity O(1) - Constant space complexity. The algorithm only uses a few extra variables regardless of the input size.


"""