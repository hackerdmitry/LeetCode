using System;

namespace LeetCode._2._Middle._1921._Eliminate_Maximum_Number_of_Monsters;

public class Solution
{
    public int EliminateMaximum(int[] dist, int[] speed)
    {
        var countOfSteps = new int[dist.Length];
        for (int i = 0; i < dist.Length; i++)
        {
            countOfSteps[i] = dist[i] / speed[i];
            if (dist[i] % speed[i] != 0)
                countOfSteps[i]++;
        }

        Array.Sort(countOfSteps);

        for (int i = 0; i < dist.Length; i++)
        {
            if (countOfSteps[i] <= i)
                return i;
        }

        return dist.Length;
    }
}