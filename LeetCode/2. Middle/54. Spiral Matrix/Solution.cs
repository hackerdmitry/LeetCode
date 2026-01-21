using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._54._Spiral_Matrix;

public class Solution
{
    private readonly int[] directions = {0, 1, 0, -1, 0};

    public IList<int> SpiralOrder(int[][] matrix)
    {
        var n = matrix.Length;
        var m = matrix[0].Length;
        return SpiralEnumerable(matrix, m, n).ToArray();
    }

    private IEnumerable<int> SpiralEnumerable(int[][] matrix, int m, int n)
    {
        var countDirection = new[] {m - 1, n - 1, m - 1, n - 2};
        var isFirst = true;
        var first = countDirection[0] > 0 ? 0 : 1;

        var y = 0;
        var x = 0;

        yield return matrix[0][0];
        while (true)
        {
            for (var i = isFirst ? first : 0; i < countDirection.Length; i++)
            {
                if (countDirection[i] <= 0)
                    yield break;
                for (var j = 0; j < countDirection[i]; j++)
                    yield return Step(matrix, ref y, ref x, i);
                if (i == 0 && countDirection[0] == countDirection[2])
                    countDirection[i]--;
                else
                    countDirection[i] -= 2;
            }

            isFirst = false;
        }
    }

    private int Step(int[][] matrix, ref int y, ref int x, int direction)
    {
        y += directions[direction];
        x += directions[direction + 1];
        return matrix[y][x];
    }
}