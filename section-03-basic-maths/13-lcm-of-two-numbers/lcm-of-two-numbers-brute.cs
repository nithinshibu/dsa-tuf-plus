using System;

public class Solution
{
    // Function to find LCM of n1 and n2
    public int LCM(int n1, int n2)
    {
        // Variable to store lcm
        int lcm;

        // Variable to store max of n1 & n2
        int n = Math.Max(n1, n2);
        int i = 1;

        while (true)
        {
            // Variable to store multiple
            int mul = n * i;

            /* Checking if multiple is common
            common for both n1 and n2 */
            if (mul % n1 == 0 && mul % n2 == 0)
            {
                lcm = mul;
                break;
            }
            i++;
        }

        // Return the stored LCM
        return lcm;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Input values
        int n1 = 4;
        int n2 = 12;

        /* Creating an instance of 
        Solution class */
        Solution sol = new Solution();

        // Function call to get LCM of n1 and n2
        int ans = sol.LCM(n1, n2);
        Console.WriteLine("The LCM of " + n1 + " and " + n2 + " is: " + ans);
    }
}


/* 

Time Complexity: O(min(N1, N2)) – In the worst-case scenario, when n1 and n2 are coprime, the loop runs for O(n1 * n2 / max(n1, n2)) iterations which is equivalent to O(min(n1, n2)).

Space Complexity: O(1) – Using a couple of variables i.e., constant space.

 */