using System;

namespace LeetCode._2._Middle._3147._Taking_Maximum_Energy_From_the_Mystic_Dungeon;

public class Solution
{
    public int MaximumEnergy(int[] energy, int k)
    {
        var maxEnergy = int.MinValue;

        for (var counter = 0; counter < energy.Length; counter++)
        {
            var i = energy.Length - 1 - counter;
            if (counter < k)
                maxEnergy = Math.Max(maxEnergy, energy[i]);
            else
            {
                var ik = energy.Length - 1 - counter % k;
                energy[ik] += energy[i];
                maxEnergy = Math.Max(maxEnergy, energy[ik]);
            }
        }

        return maxEnergy;
    }
}
