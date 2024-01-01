using System.Linq;

namespace LeetCode._1._Easy._455._Assign_Cookies;

public class Solution
{
    public int FindContentChildren(int[] g, int[] s)
    {
        g = g.OrderBy(x => x).ToArray();
        s = s.OrderBy(x => x).ToArray();

        var result = 0;

        var si = 0;
        for (var gi = 0; gi < g.Length; gi++)
        {
            while (si < s.Length && s[si] < g[gi])
                si++;

            if (si == s.Length)
                break;

            result++;
            si++;
        }

        return result;
    }
}
