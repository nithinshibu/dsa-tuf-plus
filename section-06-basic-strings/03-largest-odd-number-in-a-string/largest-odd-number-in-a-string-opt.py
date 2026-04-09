class Solution:
    def largeOddNum(self, s: str) -> str:
        last_odd_index = -1
        for i in range(len(s) - 1, -1, -1):
            if int(s[i]) % 2 == 1:
                last_odd_index = i
                break

        if last_odd_index == -1:
            return ""

        start_index = 0
        while start_index <= last_odd_index and s[start_index] == "0":
            start_index += 1

        return s[start_index : last_odd_index + 1]


""" 

range(start, stop, step) generates numbers from start → stop (exclusive) using step.
Here: range(len(s) - 1, -1, -1)
start = len(s) - 1 → last index of the string
stop = -1 → loop stops before -1 (so it includes index 0)
step = -1 → move backwards
So it iterates like: n-1, n-2, ..., 0
👉 In short: loop from right to left through the string

"""