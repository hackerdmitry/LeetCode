using System.Linq;

namespace LeetCode._1._Easy._2418._Sort_the_People;

public class Solution
{
    public string[] SortPeople(string[] names, int[] heights)
    {
        return Enumerable.Range(0, names.Length)
            .Select(i => (names[i], heights[i]))
            .OrderByDescending(x => x.Item2)
            .Select(x => x.Item1)
            .ToArray();
    }
}
