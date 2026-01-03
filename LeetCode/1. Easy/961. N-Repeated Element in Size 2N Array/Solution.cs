using System.Collections.Generic;

namespace LeetCode._1._Easy._961._N_Repeated_Element_in_Size_2N_Array;

public class Solution
{
    public int RepeatedNTimes(int[] nums)
    {
        var bag = new HashSet<int>(nums.Length / 2 + 1);
        foreach (var num in nums)
            if (!bag.Add(num))
                return num;
        return -1;
    }
}
