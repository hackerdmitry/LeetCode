using System.Linq;

namespace LeetCode._2._Middle._2712._Minimum_Cost_to_Make_All_Characters_Equal;

public class Solution
{
    public long MinimumCost(string s)
    {
        if (s.Length == 1)
            return 0;

        var startIsOne = s[0] == '1';
        var startCount = Enumerable.Range(1, s.Length - 1).TakeWhile(i => s[i - 1] == s[i]).Count() + 1;

        var endIsOne = s[^1] == '1';
        var endCount = Enumerable.Range(1, s.Length - 1).TakeWhile(i => s[s.Length - i - 1] == s[^i]).Count() + 1;

        if (startCount == s.Length)
            return 0;

        var cost = 0L;
        while (startIsOne != endIsOne || startCount + endCount != s.Length)
        {
            if (startCount < endCount)
            {
                cost += startCount;
                startIsOne = !startIsOne;
                for (var i = startCount; i < s.Length - endCount && s[i] == '0' ^ startIsOne; i++, startCount++) ;
            }
            else
            {
                cost += endCount;
                endIsOne = !endIsOne;
                for (var i = s.Length - endCount - 1; i >= startCount && s[i] == '0' ^ endIsOne; i--, endCount++) ;
            }
        }

        return cost;
    }
}
