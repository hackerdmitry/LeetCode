using System.Linq;

namespace LeetCode._2._Middle._435._Non_overlapping_Intervals;

public class Solution
{
    public int EraseOverlapIntervals(int[][] intervals)
    {
        var maxNonOverlappingCount = 0;

        var prevValidEndInterval = int.MinValue;
        foreach (var interval in intervals.OrderBy(x => x[1]).ThenBy(x => x[0]))
            if (prevValidEndInterval <= interval[0])
            {
                maxNonOverlappingCount++;
                prevValidEndInterval = interval[1];
            }

        return intervals.Length - maxNonOverlappingCount;
    }
}
