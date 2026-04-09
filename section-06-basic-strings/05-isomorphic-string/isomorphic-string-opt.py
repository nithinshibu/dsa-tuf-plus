class Solution:
    def isomorphicString(self, s, t):
        # Arrays to store the last seen positions of characters in s and t
        m1, m2 = [0] * 256, [0] * 256
        
        # Length of the string
        n = len(s)
        
        # Iterate through each character in the strings
        for i in range(n):
            # If the last seen positions of the current characters don't match, return false
            if m1[ord(s[i])] != m2[ord(t[i])]:
                return False
            
            # Update the last seen positions
            m1[ord(s[i])] = i + 1
            m2[ord(t[i])] = i + 1
        
        # If all characters match, return true
        return True

# Main method for testing
if __name__ == "__main__":
    solution = Solution()
    s = "egg"
    t = "add"
    if solution.isomorphicString(s, t):
        print("Strings are isomorphic.")
    else:
        print("Strings are not isomorphic.")



""" 

m1, m2 = [0] * 256, [0] * 256

It creates two separate lists, each of size 256, filled with 0.

256 represents the total number of possible ASCII characters.

In ASCII encoding:
Total characters = 256 (0 → 255)
Each character maps to a number

| Character | ASCII Value |
| --------- | ----------- |
| `'a'`     | 97          |
| `'b'`     | 98          |
| `'A'`     | 65          |
| `'0'`     | 48          |


What is ord() in Python?

ord() converts a character → integer (ASCII / Unicode value)

ord('a')   # 97
ord('A')   # 65
ord('0')   # 48
ord('z')   # 122

Why do we need ord() here?

m1[ord(s[i])]

Lists can only be indexed using numbers, not characters.

'a' → ❌ invalid index
97 → ✅ valid index


"""