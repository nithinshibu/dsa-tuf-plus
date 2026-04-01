public class Solution
{
    public void reverseString(char[] s)
    {
        int left = 0,
            right = s.Length - 1;
        while (left < right)
        {
            char tmp = s[left];
            s[left] = s[right];
            s[right] = tmp;
            left++;
            right--;
        }
    }
}


/* 

public class Solution
{
    public void reverseString(char[] s)
    {
        int left = 0, right = s.Length - 1;

        while (left < right)
        {
            (s[left], s[right]) = (s[right], s[left]);
            left++;
            right--;
        }
    }
}

*/