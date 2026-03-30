import math
class Solution:
    def isPerfect(self, n: int) -> bool:
        if n==1:
            return False
        sum=0
        for i in range(1,int(math.sqrt(n))+1):
            if(n %i ==0):
                sum += i
                if i != 1 and i !=n//i:
                    sum+=n//i
        
        if(sum==n):
            return True
        return False


""" 
1. When `i` divides `n`, there are always two divisors: `i` and `n//i`.
2. We already add `i`, so this condition decides whether to also add its pair `n//i`.
3. `i != 1` ensures we don’t add `n` itself (since when `i = 1`, `n//i = n`, which is not a proper divisor).
4. `i != n//i` ensures we don’t count the same number twice when `n` is a perfect square.
5. Example: for `n = 36` and `i = 6`, `n//i = 6`, so we add `6` only once (not twice), and for `i = 1`, we add only `1` and skip `36`.


"""