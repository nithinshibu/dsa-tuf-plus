class Solution:
    def isPrime(self, n):
        if n < 2:
            return False
        i = 2
        while i * i <= n:
            if n % i == 0:
                return False
            i += 1
        return True

    def primeUptoN(self, n):
        counter = 0
        i = 2
        while i <= n:
            if self.isPrime(i):
                counter += 1
            i += 1
        return counter
