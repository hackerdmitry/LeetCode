using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._3446._Sort_Matrix_by_Diagonals;

public class Solution
{
    public int[][] SortMatrix(int[][] grid)
    {
        for (var row = 0; row < grid.Length; row++)
            SetDiagonal(grid, row, 0, GetDiagonal(grid, row, 0).OrderByDescending(x => x));
        for (var col = 1; col < grid[0].Length; col++)
            SetDiagonal(grid, 0, col, GetDiagonal(grid, 0, col).OrderBy(x => x));
        return grid;
    }

    private IEnumerable<int> GetDiagonal(int[][] grid, int row, int col)
    {
        while (row < grid.Length && col < grid[0].Length)
            yield return grid[row++][col++];
    }

    private void SetDiagonal(int[][] grid, int row, int col, IEnumerable<int> values)
    {
        foreach (var value in values)
            grid[row++][col++] = value;
    }
}
