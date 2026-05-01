using System;

public class Solution
{
    public string LargeOddNum(string s)
    {
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if ((s[i] - '0') % 2 != 0)
            {
                return s.Substring(0, i + 1).TrimStart('0');
            }
        }
        return "";
    }

}


/* 

s = "1234"
s[i] = '3'   // NOT the number 3, it's a char

'3' → ASCII value 51

'0' → ASCII value 48

'3' - '0'
= 51 - 48
= 3   ✅ actual number

⏱️ Time Complexity — O(n)
You loop from right to left once → that takes n steps in worst case.
Substring(0, i+1) and TrimStart('0') together also take up to n time.
So overall, everything is linear → O(n).


📦 Space Complexity — O(n)
Substring creates a new string → can take up to n space.
TrimStart may create another new string → again up to n space.
So extra space used is proportional to input size → O(n).



 */