namespace LeetCode._2._Middle._2482._Difference_Between_Ones_and_Zeros_in_Row_and_Column;

public class Solution
{
    public int[][] OnesMinusZeros(int[][] grid)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        var onesRow = new int[m];
        var zerosRow = new int[m];
        var onesCol = new int[n];
        var zerosCol = new int[n];

        for (var i = 0; i < m; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (grid[i][j] == 0)
                {
                    zerosRow[i]++;
                    zerosCol[j]++;
                }
                else
                {
                    onesRow[i]++;
                    onesCol[j]++;
                }
            }
        }

        var diff = new int[m][];
        for (var i = 0; i < m; i++)
        {
            diff[i] = new int[n];
            for (var j = 0; j < n; j++)
                diff[i][j] = onesRow[i] + onesCol[j] - zerosRow[i] - zerosCol[j];
        }

        return diff;
    }
}
