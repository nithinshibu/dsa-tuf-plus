class Solution:
    # Function to find whether the
    # number is prime or not
    def isPrime(self, n):
        # Edge case
        if n < 2:
            return False

        # Loop from 2 to √n
        i = 2
        while i * i <= n:
            # Check if i is a divisor
            if n % i == 0:
                return False
            i += 1

        # Return true as the number is prime
        return True

if __name__ == "__main__":
    n = 5

    # Creating an instance of 
    # Solution class
    sol = Solution()

    # Function call to find whether the
    # given number is prime or not
    ans = sol.isPrime(n)

    if ans:
        print(f"{n} is a prime number.")
    else:
        print(f"{n} is not a prime number.")







""" 
For Loop approach 

import math


class Solution:
    def isPrime(self, n):
        if n < 2:
            return False

        for i in range(2, int(math.sqrt(n)) + 1):
            if n % i == 0:
                return False

        return True

        
"""