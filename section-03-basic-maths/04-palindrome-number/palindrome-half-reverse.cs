using System;

public class Solution
{
    public bool IsPalindrome(int x)
    {
        // Negative numbers are not palindrome
        // Numbers ending with 0 (except 0 itself) also cannot be palindrome
        if (x < 0 || (x % 10 == 0 && x != 0))
            return false;

        int reversedHalf = 0;

        // Reverse only half of the number
        while (x > reversedHalf)
        {
            int digit = x % 10;
            reversedHalf = reversedHalf * 10 + digit;
            x = x / 10;
        }

        // For even digits: x == reversedHalf
        // For odd digits: x == reversedHalf / 10 (middle digit ignored)
        return x == reversedHalf || x == reversedHalf / 10;
    }
}

public class Program
{
    public static void Main()
    {
        Solution sol = new Solution();

        int n = 12321;

        bool ans = sol.IsPalindrome(n);

        Console.WriteLine(ans
            ? "The number is palindrome"
            : "The number is not palindrome");
    }
}

/*

How It Works (Step Example)

Example: 12321

x	reversedHalf
12321	0
1232	1
123	12
12	123

Loop stops when:

x <= reversedHalf

Now check:

x == reversedHalf / 10
12 == 123/10
12 == 12 ✔

Palindrome.

Why This Works

For palindrome numbers:

12321
12 | 3 | 21

We reverse only the second half:

21 → 12

Then compare with the first half.

Middle digit (3) does not matter.

*/