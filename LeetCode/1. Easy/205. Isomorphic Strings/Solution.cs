namespace LeetCode._1._Easy._205._Isomorphic_Strings;

public class Solution
{
    public bool IsIsomorphic(string s, string t)
    {
        var isomorphicArr = new char[256];
        var tVisited = new bool[256];
        for (var i = 0; i < s.Length; i++)
            if (isomorphicArr[s[i]] == 0 && !tVisited[t[i]])
            {
                isomorphicArr[s[i]] = t[i];
                tVisited[t[i]] = true;
            }
            else if (isomorphicArr[s[i]] != t[i])
                return false;

        return true;
    }
}