using System;

namespace LeetCode._1._Easy._1732._Find_the_Highest_Altitude;

public class Solution
{
    public int LargestAltitude(int[] gain)
    {
        var largestAltitude = 0;
        var currentAltitude = 0;

        foreach (var currentGain in gain)
        {
            currentAltitude += currentGain;
            largestAltitude = Math.Max(largestAltitude, currentAltitude);
        }

        return largestAltitude;
    }
}
