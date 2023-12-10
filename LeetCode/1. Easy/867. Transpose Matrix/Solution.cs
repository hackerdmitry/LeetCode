namespace LeetCode._1._Easy._867._Transpose_Matrix;

public class Solution
{
    public int[][] Transpose(int[][] matrix)
    {
        var result = new int[matrix[0].Length][];
        for (var i = 0; i < matrix[0].Length; i++)
        {
            result[i] = new int[matrix.Length];
            for (var j = 0; j < matrix.Length; j++)
                result[i][j] = matrix[j][i];
        }

        return result;
    }
}
