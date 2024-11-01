using System.Text;

namespace LeetCode._1._Easy._1957._Delete_Characters_to_Make_Fancy_String;

public class Solution
{
    public string MakeFancyString(string s)
    {
        if (s.Length < 3)
            return s;

        var stringBuilder = new StringBuilder(s.Length);
        stringBuilder.Append(s[0]);
        stringBuilder.Append(s[1]);
        for (var i = 2; i < s.Length; i++)
        {
            if (s[i] == s[i - 1] && s[i] == s[i - 2])
                continue;

            stringBuilder.Append(s[i]);
        }

        return stringBuilder.ToString();
    }
}
