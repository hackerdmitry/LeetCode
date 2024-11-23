namespace LeetCode._2._Middle._1861._Rotating_the_Box;

public class Solution
{
    public char[][] RotateTheBox(char[][] box)
    {
        var m = box.Length;
        var n = box[0].Length;
        var rotatedBox = new char[n][];

        for (var i = 0; i < n; i++)
            rotatedBox[i] = new char[m];

        for (var i = 0; i < m; i++)
        {
            var obstacleIndex = n;
            var countStones = 0;
            for (var j = n - 1; j >= 0; j--)
            {
                switch (box[i][j])
                {
                    case '*':
                        FillStones(rotatedBox, m - i - 1, obstacleIndex, countStones, j);
                        countStones = 0;
                        obstacleIndex = j;
                        break;
                    case '#':
                        countStones++;
                        break;
                }
            }

            FillStones(rotatedBox, m - i - 1, obstacleIndex, countStones, 0);
        }

        return rotatedBox;
    }

    private void FillStones(char[][] row, int columnIndex, int obstacleIndex, int countStones, int endIndex)
    {
        if (row.Length != obstacleIndex)
            row[obstacleIndex][columnIndex] = '*';

        for (var i = obstacleIndex - 1; i >= endIndex; i--)
        {
            if (countStones > 0)
            {
                row[i][columnIndex] = '#';
                countStones--;
            }
            else
                row[i][columnIndex] = '.';
        }
    }
}