using System.Linq;

namespace LeetCode._2._Middle._452._Minimum_Number_of_Arrows_to_Burst_Balloons;

public class Solution
{
    public int FindMinArrowShots(int[][] points)
    {
        var prevArrow = 0;
        var arrowCount = 0;
        foreach (var point in points.OrderBy(x => x[1]).ThenBy(x => x[0]))
            if (arrowCount == 0 || prevArrow < point[0] || point[1] < prevArrow)
            {
                arrowCount++;
                prevArrow = point[1];
            }

        return arrowCount;
    }
}
