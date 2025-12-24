using System;
using System.Linq;

namespace LeetCode._1._Easy._3074._Apple_Redistribution_into_Boxes;

public class Solution
{
    public int MinimumBoxes(int[] apple, int[] capacity)
    {
        Array.Sort(capacity, (c1, c2) => c2 - c1);
        var appleSum = apple.Sum();

        var capacityIndex = 0;
        while (appleSum > 0)
            appleSum -= capacity[capacityIndex++];

        return capacityIndex;
    }
}