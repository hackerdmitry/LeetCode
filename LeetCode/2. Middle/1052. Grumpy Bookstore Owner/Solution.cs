using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._1052._Grumpy_Bookstore_Owner;

public class Solution
{
    public int MaxSatisfied(int[] customers, int[] grumpy, int minutes)
    {
        var maxPleasantMinutes = 0;
        for (var i = 0; i < customers.Length; i++)
            if (grumpy[i] == 0)
                maxPleasantMinutes += customers[i];

        var curPleasantMinutes = maxPleasantMinutes;
        for (var i = 0; i < customers.Length; i++)
        {
            if (grumpy[i] == 1)
                curPleasantMinutes += customers[i];

            if (i >= minutes)
                if (grumpy[i - minutes] == 1)
                    curPleasantMinutes -= customers[i - minutes];

            maxPleasantMinutes = Math.Max(maxPleasantMinutes, curPleasantMinutes);
        }

        return maxPleasantMinutes;
    }
}
