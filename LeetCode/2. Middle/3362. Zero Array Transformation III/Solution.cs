using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._3362._Zero_Array_Transformation_III;

public class Solution
{
    public int MaxRemoval(int[] nums, int[][] queries)
    {
        var currentUseful = 0;
        var periods = queries.Select(x => new Period
        {
            From = x[0],
            To = x[1],
            IsUseful = false,
        }).ToArray();

        var fromPeriods = periods.GroupBy(x => x.From).ToDictionary(x => x.Key, x => x);
        var toPeriods = periods.GroupBy(x => x.To).ToDictionary(x => x.Key, x => x);
        var priorityQueuePeriods = new PriorityQueue<Period, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (fromPeriods.TryGetValue(i, out var fromPeriod))
                foreach (var period in fromPeriod)
                    priorityQueuePeriods.Enqueue(period, -period.To);

            while (currentUseful < nums[i])
            {
                if (priorityQueuePeriods.Count == 0)
                    return -1;

                var period = priorityQueuePeriods.Dequeue();
                if (period.To >= i)
                {
                    period.IsUseful = true;
                    currentUseful++;
                }
            }

            if (toPeriods.TryGetValue(i, out var toPeriod))
                foreach (var period in toPeriod)
                    if (period.IsUseful)
                        currentUseful--;
        }

        return periods.Count(x => !x.IsUseful);
    }

    private class Period
    {
        public int From { get; set; }
        public int To { get; set; }
        public bool IsUseful { get; set; }
    }
}