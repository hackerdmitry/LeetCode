namespace LeetCode._2._Middle._91._Decode_Ways;

public class Solution
{
    public int NumDecodings(string s)
    {
        if (s[0] == '0')
            return 0;

        var groups = new int[s.Length];
        groups[0] = 1;

        for (var i = 1; i < s.Length; i++)
        {
            if (s[i] != '0')
                groups[i] = groups[i - 1];

            if (s[i-1] != '0')
            {
                var twoDigit = (s[i - 1] - '0') * 10 + s[i] - '0';
                if (twoDigit <= 26)
                    groups[i] += i > 1 ? groups[i - 2] : 1;
            }
        }

        return groups[^1];
    }
}
