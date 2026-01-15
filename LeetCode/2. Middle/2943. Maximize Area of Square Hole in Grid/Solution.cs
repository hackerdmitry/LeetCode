using System;

namespace LeetCode._2._Middle._2943._Maximize_Area_of_Square_Hole_in_Grid;

public class Solution
{
    public int MaximizeSquareHoleArea(int n, int m, int[] hBars, int[] vBars)
    {
        var maxRowHBarsCount = MaxRowCount(hBars);
        var maxRowVBarsCount = MaxRowCount(vBars);
        var minRowBarsCount = Math.Min(maxRowVBarsCount, maxRowHBarsCount) + 1;
        return minRowBarsCount * minRowBarsCount;
    }

    private int MaxRowCount(int[] bars)
    {
        var result = 1;
        Array.Sort(bars);
        var currentRow = 1;
        for (var i = 1; i < bars.Length; i++)
        {
            if (bars[i - 1] + 1 == bars[i])
                currentRow++;
            else
                currentRow = 1;

            if (currentRow > result)
                result = currentRow;
        }

        return result;
    }
}
