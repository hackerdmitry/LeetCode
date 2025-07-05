using System.Linq;

namespace LeetCode._1._Easy._1394._Find_Lucky_Integer_in_an_Array;

public class Solution
{
    public int FindLucky(int[] arr)
    {
        return arr.GroupBy(x => x)
            .Where(x => x.Key == x.Count())
            .Select(x => (int?) x.Key)
            .OrderByDescending(x => x)
            .FirstOrDefault() ?? -1;
    }
}