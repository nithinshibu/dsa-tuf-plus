using System;
using System.Collections.Generic;

class Solution {

    /* Function to find all 
    divisors of n */
    public List<int> divisors(int n) {

        // To store the divisors;
        List<int> ans = new List<int>();

        // Iterate from 1 to n
        for (int i = 1; i <= n; i++) {

            // If a divisor is found
            if (n % i == 0) {
                // Add it to the answer
                ans.Add(i);
            }
        }

        // Return the result
        return ans;
    }
}

class Program {
    static void Main() {
        int n = 6;

        /* Creating and instance of 
        Solution class */
        Solution sol = new Solution();

        /* Function call to find 
        all divisors of n */
        List<int> ans = sol.divisors(n);

        Console.Write("The divisors of " + n + " are: ");
        for (int i = 0; i < ans.Count; i++) {
            Console.Write(ans[i] + " ");
        }
    }
}

/* 

------Time Complexity------
O(n)

Why?

Your loop runs from 1 to n
That means n iterations

Inside the loop → only constant work (% and Add)

So total work = n × constant = O(n)

Simple way to remember

“If I loop till n → time complexity is O(n)”


------Space Complexity------
Final Answer: O(k) (or worst case O(n))

Why?

You are storing all divisors in a list

Number of divisors = k

Example:

n = 6 → divisors = [1,2,3,6] → k = 4
n = 12 → k = 6

In worst case, k can go up to n (very rare but theoretically)

So:

Best/average → O(k)
Worst case → O(n)

“Space = number of results stored”

 */