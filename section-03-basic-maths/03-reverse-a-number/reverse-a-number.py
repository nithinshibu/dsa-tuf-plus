class Solution:
    # Function to reverse given number n
    def reverseNumber(self, n):
        """ After the code, revNum will
        contain the reversed number """
        revNum = 0
        
        """ Keep on iterating while there
        are digits left to extract """
        while n > 0:
            lastDigit = n % 10
            
            """ Pushing last digit at the
            back of reversed number """
            revNum = (revNum * 10) + lastDigit
            n = n // 10
        
        return revNum

if __name__ == "__main__":
    n = 6678
    
    """ Creating an instance of 
    Solution class """
    sol = Solution()
    
    # Function call to reverse the digits in n
    ans = sol.reverseNumber(n)
    print("The reverse of given number is:", ans)
