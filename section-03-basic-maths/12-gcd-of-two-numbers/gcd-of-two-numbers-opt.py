class Solution:
    # Function to find the GCD of two numbers
    def GCD(self, n1, n2):
        
        # Continue loop as long as both n1 and 
        # n2 are greater than zero
        while n1 > 0 and n2 > 0:
            
            # If n1 is greater than n2, perform 
            # modulo operation - n1 % n2
            if n1 > n2:
                n1 = n1 % n2
            
            # Else perform modulo operation - n2 % n1
            else:
                n2 = n2 % n1
        
        # If n1 is zero, GCD is stored in n2
        if n1 == 0:
            return n2
        
        # else GCD is stored in n1
        return n1

# Input numbers
n1 = 4
n2 = 6

# Creating an instance of Solution class
sol = Solution()

# Function call to find the gcd of two numbers
ans = sol.GCD(n1, n2)

print("GCD of", n1, "and", n2, "is:", ans)
