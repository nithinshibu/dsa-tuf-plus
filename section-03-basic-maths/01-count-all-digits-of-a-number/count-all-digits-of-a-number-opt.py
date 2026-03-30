import math

class Solution:
    # Function to count the
    # number of odd digits in N
    def countDigit(self, n):
        # Edge case
        if n == 0:
            return 1
            
        count = int(math.log10(n) + 1)
        return count

# Input number
n = 6678

# Creating an instance of Solution class
sol = Solution()

# Function call to get count of digits in n
ans = sol.countDigit(n)
print("The count of digits in the given number is:", ans)