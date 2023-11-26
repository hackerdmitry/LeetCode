using System.Linq;

namespace LeetCode._2._Middle._1727._Largest_Submatrix_With_Rearrangements;

public class Solution
{
    public int LargestSubmatrix(int[][] matrix)
    {
        var m = matrix.Length;
        var n = matrix[0].Length;

        for (var i = 0; i < n; i++)
            for (var j = 1; j < m; j++)
            {
                if (matrix[j][i] == 0)
                    continue;
                matrix[j][i] = matrix[j - 1][i] + 1;
            }

        var result = 0;
        for (var i = 0; i < m; i++)
        {
            var localMax = matrix[i].OrderByDescending(x => x).Select((x, c) => x * (c + 1)).Max();
            if (localMax > result)
                result = localMax;
        }

        return result;
    }
}
