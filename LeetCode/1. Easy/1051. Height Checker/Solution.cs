using System.Linq;

namespace LeetCode._1._Easy._1051._Height_Checker;

public class Solution
{
    public int HeightChecker(int[] heights)
    {
        var result = 0;

        var i = 0;
        foreach (var expected in heights.OrderBy(x => x))
            if (heights[i++] != expected)
                result++;

        return result;
    }
}