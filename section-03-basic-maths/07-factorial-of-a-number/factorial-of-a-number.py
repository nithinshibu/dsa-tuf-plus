class Solution:
    # Function to find the
    # factorial of a number
    def factorial(self, n):
        # Edge Case
        if n == 0:
            return 1
            
        # Variable to store the factorial
        fact = 1

        # Iterate from 1 to n
        for i in range(1, n + 1):
            # Multiply fact with current number
            fact = fact * i
        
        # Return the factorial stored
        return fact

# Input number
n = 4

# Creating an instance of Solution class
sol = Solution()

# Function call to find the factorial of n
ans = sol.factorial(n)

print("The factorial of given number is:", ans)
