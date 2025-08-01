using System.Collections.Generic;

namespace LeetCode._1._Easy._118._Pascal_s_Triangle;

public class Solution
{
    public IList<IList<int>> Generate(int numRows)
    {
        var result = new List<IList<int>> {new[] {1}};

        var lastLength = 1;
        while (--numRows > 0)
        {
            result.Add(new int[++lastLength]);
            result[^1][0] = 1;
            result[^1][^1] = 1;
            for (var i = 1; i < lastLength - 1; i++)
                result[^1][i] = result[^2][i - 1] + result[^2][i];
        }

        return result;
    }
}
