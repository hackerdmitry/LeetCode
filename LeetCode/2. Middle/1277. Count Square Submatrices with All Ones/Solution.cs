using System;

namespace LeetCode._2._Middle._1277._Count_Square_Submatrices_with_All_Ones;

public class Solution
{
    public int CountSquares(int[][] matrix)
    {
        ScetchSquares(matrix);
        return CalculateResult(matrix);
    }

    private void ScetchSquares(int[][] matrix)
    {
        for (var i = 1; i < matrix.Length; i++)
            for (var j = 1; j < matrix[i].Length; j++)
                if (matrix[i][j] == 1)
                    matrix[i][j] = GetMin(matrix[i][j - 1], matrix[i - 1][j], matrix[i - 1][j - 1]) + 1;
    }

    private int CalculateResult(int[][] matrix)
    {
        var result = 0;
        for (var i = 0; i < matrix.Length; i++)
            for (var j = 0; j < matrix[i].Length; j++)
                result += matrix[i][j];

        return result;
    }

    private int GetMin(int n1, int n2, int n3)
    {
        return Math.Min(n1, Math.Min(n2, n3));
    }
}
