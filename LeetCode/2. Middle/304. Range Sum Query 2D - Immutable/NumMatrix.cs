namespace LeetCode._2._Middle._304._Range_Sum_Query_2D___Immutable;

public class NumMatrix
{
    private readonly int[][] matrix;

    public NumMatrix(int[][] matrix)
    {
        this.matrix = matrix;
    }

    public int SumRegion(int row1, int col1, int row2, int col2)
    {
        var sum = 0;
        for (var y = row1; y <= row2; y++)
            for (var x = col1; x <= col2; x++)
                sum += matrix[y][x];
        return sum;
    }
}