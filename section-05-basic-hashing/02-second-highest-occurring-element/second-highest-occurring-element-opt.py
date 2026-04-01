from collections import defaultdict

class Solution:
    # Function to get the second highest 
    # occurring element in array
    def secondMostFrequentElement(self, nums):    
        
        # Variable to store maximum frequency
        # and second maximum frequency 
        maxFreq = 0
        secMaxFreq = 0
        
        # Variable to store element 
        # with maximum frequency and second
        # highest frequency
        maxEle = -1
        secEle = -1
        
        # HashMap
        mpp = defaultdict(int)
        
        # Iterating on the array
        for num in nums:
            # Updating hashmap 
            mpp[num] += 1
            
        # Iterate on the map
        for ele, freq in mpp.items():
            # Update variables if new element  
            # having highest frequency or second
            # highest frequency is found
            if freq > maxFreq:
                secMaxFreq = maxFreq
                maxFreq = freq
                secEle = maxEle
                maxEle = ele
            elif freq == maxFreq:
                maxEle = min(maxEle, ele)
            elif freq > secMaxFreq:
                secMaxFreq = freq
                secEle = ele
            elif freq == secMaxFreq:
                secEle = min(secEle, ele)
        
        # Return the result
        return secEle

