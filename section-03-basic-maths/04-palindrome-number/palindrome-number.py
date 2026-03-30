class Solution:
    # Function to check if a 
    # number is palindrome or not
    def isPalindrome(self, n):
        # Create a copy of original number
        copy = n
        
        # After the code, revNum will
        # contain the reversed number
        revNum = 0

        # Keep on iterating while there
        # are digits left to extract
        while n > 0:
            lastDigit = n % 10

            # Pushing last digit at the
            # back of reversed number
            revNum = (revNum * 10) + lastDigit
            n = n // 10
        
        # Return true if the reversed and 
        # copy of original number is same
        return revNum == copy

# Input number
n = 12321

# Creating an instance of Solution class
sol = Solution()

# Function call to check if n is a palindrome
ans = sol.isPalindrome(n)

if ans:
    print("The given number is a palindrome")
else:
    print("The given number is not a palindrome")
