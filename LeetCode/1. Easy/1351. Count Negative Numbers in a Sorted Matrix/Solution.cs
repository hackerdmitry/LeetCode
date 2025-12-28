namespace LeetCode._1._Easy._1351._Count_Negative_Numbers_in_a_Sorted_Matrix;

public class Solution
{
    public int CountNegatives(int[][] grid)
    {
        var n = grid[0].Length;
        var m = grid.Length;

        var result = 0;
        var i = 0;
        for (; i < n && grid[0][i] >= 0; i++) ;

        result += n - i;

        if (i == n)
            i--;

        for (var j = 1; j < m; j++)
        {
            for (; i >= 0 && grid[j][i] < 0; i--) ;
            result += n - i - 1;
        }

        return result;
    }
}