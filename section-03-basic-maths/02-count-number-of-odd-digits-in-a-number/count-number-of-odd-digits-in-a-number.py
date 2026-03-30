class Solution:
    # Function to count number
    # of odd digits in N
    def countOddDigit(self, n):
        # Counter to store the 
        # number of odd digits
        oddDigits = 0

        # Iterate till there are digits left
        while n > 0:
            # Extract last digit
            lastDigit = n % 10
            
            # Check if digit is odd
            if lastDigit % 2 != 0:
                # Increment counter
                oddDigits = oddDigits + 1
            n = n // 10

        return oddDigits

# Input number
n = 6678

# Creating an instance of 
# Solution class
sol = Solution()

# Function call to get count of odd digits in n
ans = sol.countOddDigit(n)
print("The count of odd digits in the given number is:", ans)
