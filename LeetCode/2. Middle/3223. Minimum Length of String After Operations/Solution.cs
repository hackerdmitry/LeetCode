using System.Linq;

namespace LeetCode._2._Middle._3223._Minimum_Length_of_String_After_Operations;

public class Solution
{
    public int MinimumLength(string s)
    {
        return s.GroupBy(x => x, (_, result) => result.Count()).Sum(x => x < 3 ? x : x % 2 == 0 ? 2 : 1);
    }
}
