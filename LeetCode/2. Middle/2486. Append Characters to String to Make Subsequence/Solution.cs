namespace LeetCode._2._Middle._2486._Append_Characters_to_String_to_Make_Subsequence;

public class Solution
{
    public int AppendCharacters(string s, string t)
    {
        var ti = 0;
        for (var si = 0; si < s.Length; si++)
        {
            if (s[si] == t[ti])
                ti++;

            if (ti == t.Length)
                return 0;
        }

        return t.Length - ti;
    }
}
