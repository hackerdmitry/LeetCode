using System;

namespace LeetCode._2._Middle._1605._Find_Valid_Matrix_Given_Row_and_Column_Sums;

public class Solution
{
    public int[][] RestoreMatrix(int[] rowSum, int[] colSum)
    {
        var m = rowSum.Length;
        var n = colSum.Length;

        var result = new int[m][];

        var minColFreeIndex = 0;
        for (var i = 0; i < m; i++)
        {
            result[i] = new int[n];

            for (var j = minColFreeIndex; j < n && rowSum[i] > 0; j++)
            {
                result[i][j] = Math.Min(colSum[j], rowSum[i]);
                colSum[j] -= result[i][j];
                rowSum[i] -= result[i][j];

                if (j == minColFreeIndex && colSum[j] == 0)
                    minColFreeIndex++;
            }
        }

        return result;
    }
}
