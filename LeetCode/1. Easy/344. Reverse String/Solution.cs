namespace LeetCode._1._Easy._344._Reverse_String;

public class Solution
{
    public void ReverseString(char[] s)
    {
        var n2 = s.Length / 2;
        for (var i = 0; i < n2; i++)
            (s[i], s[^(i + 1)]) = (s[^(i + 1)], s[i]);
    }
}