class Solution:
    # Function to find the largest
    # digit in a given number
    def largestDigit(self, n):
        # Variable to store the largest digit
        largestDigit = 0

        # Keep on iterating while there
        # are digits left to extract
        while n > 0:
            lastDigit = n % 10

            # If the current digit is greater than 
            # largest digit, update largest digit
            if lastDigit > largestDigit:
                largestDigit = lastDigit

            n = n // 10

        # Return the largest digit
        return largestDigit

if __name__ == "__main__":
    n = 348

    # Creating an instance of 
    # Solution class
    sol = Solution()

    # Function call to find the largest digit in n
    ans = sol.largestDigit(n)

    print("The largest digit in the number is:", ans)
