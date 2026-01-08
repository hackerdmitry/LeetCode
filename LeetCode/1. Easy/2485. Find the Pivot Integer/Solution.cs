namespace LeetCode._1._Easy._2485._Find_the_Pivot_Integer;

public class Solution
{
    public int PivotInteger(int n)
    {
        var rightSum = n * (n + 1) / 2;
        var leftSum = 1;

        var x = 2;
        while (leftSum < rightSum)
        {
            rightSum -= x - 1;
            leftSum += x++;
        }

        return leftSum == rightSum ? x - 1 : -1;
    }
}
