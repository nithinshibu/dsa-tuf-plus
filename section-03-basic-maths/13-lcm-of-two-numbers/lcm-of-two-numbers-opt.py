class Solution:
    def GCD(self, n1, n2):
        while n1 > 0 and n2 > 0:
            if n1 > n2:
                n1 = n1 % n2
            else:
                n2 = n2 % n1
        if n1 == 0:
            return n2
        else:
            return n1

    def LCM(self, n1, n2):
        gcd = self.GCD(n1, n2)
        return n1 * n2 // gcd


""" 
"The GCD function uses the Euclidean algorithm, where in each step we replace the larger number with its remainder when divided by the smaller number. This operation significantly reduces the size of the numbers in each iteration.

On average, the numbers shrink exponentially, meaning the number of steps grows logarithmically with respect to the smaller input. Therefore, the time complexity is O(log(min(n1, n2)))."

"""