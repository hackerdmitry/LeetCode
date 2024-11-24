using System;

namespace LeetCode._2._Middle._1975._Maximum_Matrix_Sum;

public class Solution
{
    public long MaxMatrixSum(int[][] matrix)
    {
        var n = matrix.Length;

        var closestToZeroNumber = int.MaxValue;
        var countNegativeNumbers = 0;
        var sum = 0L;

        for (var i = 0; i < n; i++)
            for (var j = 0; j < n; j++)
            {
                var number = matrix[i][j];
                if (Math.Abs(number) < Math.Abs(closestToZeroNumber))
                    closestToZeroNumber = number;

                if (number < 0)
                    countNegativeNumbers++;

                sum += Math.Abs(number);
            }

        return countNegativeNumbers % 2 == 1
            ? sum - 2 * Math.Abs(closestToZeroNumber)
            : sum;
    }
}