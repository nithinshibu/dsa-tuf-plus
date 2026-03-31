class Solution:
    # Function to get the sum of array elements
    def sum(self, arr, n):
        total = 0  # to store the answer

        # Iterate on all the elements
        for i in range(n):
            # Add the current element to the sum
            total = total + arr[i]

        # Return the result
        return total


# Main method
if __name__ == "__main__":
    n = 4
    arr = [1, 2, 3, 8]

    # Creating an instance of solution class
    sol = Solution()

    # Function call to get the sum of array elements
    result = sol.sum(arr, n)

    # output the result
    print("The sum of array elements is:", result)
