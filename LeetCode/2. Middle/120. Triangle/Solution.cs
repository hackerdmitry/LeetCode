using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._120._Triangle;

public class Solution
{
    public int MinimumTotal(IList<IList<int>> triangle)
    {
        for (var i = 1; i < triangle.Count; i++)
            for (var j = 0; j < triangle[i].Count; j++)
            {
                var left = j == 0 ? int.MaxValue : triangle[i - 1][j - 1];
                var right = j == i ? int.MaxValue : triangle[i - 1][j];
                triangle[i][j] += Math.Min(left, right);
            }

        return triangle[^1].Min();
    }
}
