namespace LeetCode._2._Middle._2579._Count_Total_Number_of_Colored_Cells;

public class Solution
{
    public long ColoredCells(int n)
    {
        var count = 1L;
        while (--n > 0)
            count += n * 4;
        return count;
    }
}
