using System;

namespace LeetCode._2._Middle._1578._Minimum_Time_to_Make_Rope_Colorful;

public class Solution
{
    public int MinCost(string colors, int[] neededTime)
    {
        var result = 0;
        for (var i = 1; i < colors.Length; i++)
            if (colors[i] == colors[i - 1])
            {
                var sumTime = neededTime[i] + neededTime[i - 1];
                var maxTime = Math.Max(neededTime[i], neededTime[i - 1]);
                var lastJ = i + 1;
                for (var j = i + 1; j < colors.Length && colors[j] == colors[i]; j++)
                {
                    maxTime = Math.Max(maxTime, neededTime[j]);
                    sumTime += neededTime[j];
                    lastJ = j;
                }

                result += sumTime - maxTime;
                i = lastJ;
            }

        return result;
    }
}
