using System.Collections.Generic;
using System.Linq;

namespace LeetCode._1._Easy._1380._Lucky_Numbers_in_a_Matrix;

public class Solution
{
    public IList<int> LuckyNumbers(int[][] matrix)
    {
        var result = new List<int>();

        var n = matrix.Length;
        var m = matrix[0].Length;

        for (var y = 0; y < n; y++)
        {
            var minRowIndex = -1;
            var minRowNumber = int.MaxValue;

            for (var x = 0; x < m; x++)
                if (matrix[y][x] < minRowNumber)
                {
                    minRowNumber = matrix[y][x];
                    minRowIndex = x;
                }

            if (Enumerable.Range(0, n).Max(y => matrix[y][minRowIndex]) == minRowNumber)
                result.Add(minRowNumber);
        }

        return result;
    }
}
