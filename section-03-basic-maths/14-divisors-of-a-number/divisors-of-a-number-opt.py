import math


class Solution:
    def divisors(self, n):
        ans = []
        for i in range(1, int(math.sqrt(n)) + 1):
            if n % i == 0:
                ans.append(i)

                if i != n // i:
                    ans.append(n // i)

        ans.sort()

        return ans





""" 
Time Complexity
O(sqrt(n) + d log d) where d is the number of divisors of n, because the loop runs sqrt(n) times and sorting the divisors takes d log d
Space Complexity
O(d) where d is the number of divisors of n, as we store all divisors in the ans list


"We iterate only up to √n to find divisor pairs, which takes O(√n) time. For each divisor, we store it in a list, which takes O(d), where d is the number of divisors. Finally, we sort the list of divisors, which takes O(d log d). So overall complexity is O(√n + d log d)."


Sorting takes O(d log d) because Python uses Timsort, which is a comparison-based sorting algorithm. In comparison-based sorting, we need about log d levels of comparisons, and at each level we compare up to d elements. So overall, the number of operations becomes proportional to d log d.

"""