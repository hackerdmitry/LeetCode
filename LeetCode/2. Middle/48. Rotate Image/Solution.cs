namespace LeetCode._2._Middle._48._Rotate_Image;

public class Solution
{
    public void Rotate(int[][] matrix)
    {
        var n = matrix.Length;
        var lineLength = n - 1;
        for (var y = 0; y < n / 2; y++)
        {
            for (var x = y; x < y + lineLength; x++)
            {
                var distanceX = y + lineLength - x;
                var distanceY = lineLength - distanceX;
                Rotate(matrix, y, x, distanceY, distanceX);
            }

            lineLength -= 2;
        }
    }

    private void Rotate(int[][] matrix, int y, int x, int distanceY, int distanceX)
    {
        var temp = matrix[y][x];
        matrix[y][x] = matrix[y + distanceY][x + distanceX];

        for (var d = 0; d < 4; d++)
        {
            x += distanceX;
            y += distanceY;
            (temp, matrix[y][x]) = (matrix[y][x], temp);
            (distanceY, distanceX) = (distanceX, -distanceY);
        }
    }
}
