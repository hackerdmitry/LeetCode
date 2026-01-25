using System;
using System.Linq;

namespace LeetCode._2._Middle._57._Insert_Interval;

public class Solution
{
    public int[][] Insert(int[][] intervals, int[] newInterval)
    {
        var overlappedIntervals = intervals.Count(interval => IsOverlap(interval, newInterval));

        var index = 0;
        var result = new int[intervals.Length - overlappedIntervals + 1][];

        foreach (var interval in intervals)
            if (IsOverlap(interval, newInterval))
                MergeIntervals(newInterval, interval);
            else if (index == 0 && newInterval[1] < interval[0] ||
                     index > 0 && result[index - 1][1] < newInterval[0] && newInterval[1] < interval[0])
            {
                result[index++] = newInterval;
                result[index++] = interval;
            }
            else
                result[index++] = interval;

        if (index < result.Length)
            result[index] = newInterval;

        return result;
    }

    private void MergeIntervals(int[] interval1, int[] interval2)
    {
        interval1[0] = Math.Min(interval1[0], interval2[0]);
        interval1[1] = Math.Max(interval1[1], interval2[1]);
    }

    private bool IsOverlap(int[] interval1, int[] interval2)
    {
        return interval1[0] <= interval2[1] && interval2[0] <= interval1[1];
    }
}