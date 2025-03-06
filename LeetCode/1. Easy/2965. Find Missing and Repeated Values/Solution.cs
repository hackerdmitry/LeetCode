namespace LeetCode._1._Easy._2965._Find_Missing_and_Repeated_Values;

public class Solution
{
    public int[] FindMissingAndRepeatedValues(int[][] grid)
    {
        var exists = new bool[grid.Length * grid[0].Length];
        var result = new int[2];
        for (var i = 0; i < grid.Length; i++)
            for (var j = 0; j < grid[0].Length; j++)
                if (exists[grid[i][j] - 1])
                    result[0] = grid[i][j];
                else
                    exists[grid[i][j] - 1] = true;
        for (var i = 0; i < exists.Length; i++)
            if (!exists[i])
            {
                result[1] = i + 1;
                break;
            }

        return result;
    }
}
