using System;
using System.Collections.Generic;

class Solution
{
    /* Function to find all 
    divisors of n */
    public List<int> divisors(int n)
    {

        // To store the divisors;
        List<int> ans = new List<int>();

        int sqrtN = (int)Math.Sqrt(n);

        // Or simply we could do:-   for (int i = 1; i * n <= n; i++) {

        // Iterate from 1 to sqrtN
        for (int i = 1; i <= sqrtN; i++)
        {

            // If a divisor is found
            if (n % i == 0)
            {
                // Add it to the answer
                ans.Add(i);

                /* Add the counterpart divisor
                 if it's different from i */
                if (i != n / i)
                {
                    ans.Add(n / i);
                }
            }
        }

        // Sorting the result 
        ans.Sort();

        // Return the result
        return ans;
    }
}



/* 

------Time Complexity------

Loop runs till:

√n

So:

Time Complexity = O(√n)

Sorting:

O(k log k)

(where k = number of divisors)

Final:
O(√n + k log k)

------Space Complexity------

We store divisors:

Space Complexity = O(k)

(where k = number of divisors)

 */