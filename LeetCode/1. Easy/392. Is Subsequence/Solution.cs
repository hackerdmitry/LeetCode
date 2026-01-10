namespace LeetCode._1._Easy._392._Is_Subsequence;

public class Solution
{
    public bool IsSubsequence(string s, string t)
    {
        if (s.Length == 0)
            return true;

        var sIndex = 0;
        foreach (var c in t)
            if (c == s[sIndex])
                if (++sIndex == s.Length)
                    return true;
        return false;
    }
}
