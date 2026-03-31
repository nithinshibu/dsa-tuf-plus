class Solution:
    # Function to reverse array using two pointers
    def reverse(self, arr, n):
        left = 0
        right = n - 1
        # Swap elements pointed by p1 and 
        # p2 until they meet in the middle
        while left < right:
            tmp = arr[left]
            arr[left] = arr[right]
            arr[right] = tmp
            left += 1
            right -= 1
        # Return
        return
 
# Function to print array
def printArray(arr, n):
    for i in range(n):
        print(arr[i], end=" ")
    print()

