/*
When we do:

revNum = revNum * 10 + lastDigit

the value may exceed the C# int range.

Integer limits in C#
int.MaxValue = 2147483647
int.MinValue = -2147483648

So before multiplying by 10 we check:

revNum > int.MaxValue / 10
revNum < int.MinValue / 10

If that happens → overflow will occur.

-> Why We Check int.MaxValue / 10 ?

Example

int.MaxValue = 2147483647

If

revNum = 214748365

Next step:

revNum * 10 = 2147483650

This exceeds the integer limit → overflow.

So we check before multiplication.

*/

using System;

public class Solution
{
    public int ReverseNumber(int n)
    {
        int revNum = 0;

        while (n != 0)
        {
            int lastDigit = n % 10;
            n = n / 10;

            // Overflow check
            if (revNum > int.MaxValue / 10 || revNum < int.MinValue / 10)
            {
                return 0; // overflow case
            }

            revNum = revNum * 10 + lastDigit;
        }

        return revNum;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        int n = 1534236469;

        Solution sol = new Solution();
        int ans = sol.ReverseNumber(n);

        Console.WriteLine("Reversed number: " + ans);
    }
}

/*
Prevent Overflow Before It Happens

We check before multiplying by 10.

If:

revNum > int.MaxValue / 10

then multiplying by 10 will definitely overflow.

Why Divide by 10?

Because we want to know the largest safe number before multiplying by 10.

Calculate:

int.MaxValue = 2147483647

Divide by 10:

2147483647 / 10 = 214748364

So the largest safe value for revNum is:

214748364

If revNum becomes bigger than this, multiplying by 10 will overflow.
*/