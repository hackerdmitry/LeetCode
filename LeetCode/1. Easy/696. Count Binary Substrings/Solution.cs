namespace LeetCode._1._Easy._696._Count_Binary_Substrings;

public class Solution
{
    public int CountBinarySubstrings(string s)
    {
        var result = 0;
        for (var i = 1; i < s.Length; i++)
            if (s[i - 1] == '0' ^ s[i] == '0')
            {
                result++;
                for (var j = 1; i - j - 1 >= 0 && i + j < s.Length; result++, j++)
                    if (!(s[i - j - 1] == s[i - 1] && s[i + j] == s[i]))
                        break;
            }

        return result;
    }
}
