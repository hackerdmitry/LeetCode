using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._56._Merge_Intervals;

public class Solution
{
    public int[][] Merge(int[][] intervals)
    {
        return InternalMerge(intervals).ToArray();
    }

    private IEnumerable<int[]> InternalMerge(int[][] intervals)
    {
        var lastInterval = (int[]) null;
        foreach (var interval in intervals.OrderBy(x => x[0]))
            if (lastInterval == null)
                lastInterval = interval;
            else
            {
                if (IsOverlap(lastInterval, interval))
                {
                    lastInterval[0] = Math.Min(lastInterval[0], interval[0]);
                    lastInterval[1] = Math.Max(lastInterval[1], interval[1]);
                }
                else
                {
                    yield return lastInterval;
                    lastInterval = interval;
                }
            }
        yield return lastInterval;
    }

    private bool IsOverlap(int[] a, int[] b)
    {
        return a[1] >= b[0];
    }
}
