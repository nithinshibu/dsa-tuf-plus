class Solution:
    # Method to find the longest common prefix in a list of strings
    def longestCommonPrefix(self, strs):
        # Edge case: empty list
        if not strs:
            return ""
        
        # Sort the list to get the lexicographically smallest and largest strings
        strs.sort()
        # First string (smallest in sorted order)
        first = strs[0]  
        # Last string (largest in sorted order)
        last = strs[-1]  
        
        # Compare characters of the first and last strings
        ans = []
        for i in range(min(len(first), len(last))):
            # If characters don't match, return the current prefix
            if first[i] != last[i]:
                return ''.join(ans)
            # Append the matching character to the result
            ans.append(first[i])
        
        # Return the longest common prefix found
        return ''.join(ans)

# Test the longestCommonPrefix method
if __name__ == "__main__":
    solution = Solution()
    input_strs = ["flower", "flow", "flight"]
    result = solution.longestCommonPrefix(input_strs)
    print("Longest Common Prefix:", result)  # Output: "fl"
