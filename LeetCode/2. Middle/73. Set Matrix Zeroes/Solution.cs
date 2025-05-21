namespace LeetCode._2._Middle._73._Set_Matrix_Zeroes;

public class Solution
{
    public void SetZeroes(int[][] matrix)
    {
        var (row, column) = PlaceZeroOnBorder(matrix);
        PlaceZeroOnMatrix(matrix, row, column);
    }

    private (bool[] row, bool[] column) PlaceZeroOnBorder(int[][] matrix)
    {
        var row = new bool[matrix.Length];
        var column = new bool[matrix[0].Length];

        for (var y = 0; y < matrix.Length; y++)
            for (var x = 0; x < matrix[y].Length; x++)
                if (matrix[y][x] == 0)
                {
                    row[y] = true;
                    column[x] = true;
                }

        return (row, column);
    }

    private void PlaceZeroOnMatrix(int[][] matrix, bool[] row, bool[] column)
    {
        for (var y = 0; y < matrix.Length; y++)
            for (var x = 0; x < matrix[y].Length; x++)
                if (row[y] || column[x])
                    matrix[y][x] = 0;
    }
}