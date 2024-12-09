using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._3152._Special_Array_II;

public class Solution
{
    public bool[] IsArraySpecial(int[] nums, int[][] queries)
    {
       var specials = CreateSpecials(nums);
       var nearestSpecials = CreateNearestSpecials(specials);
       return queries.Select(q => IsSpecial(specials, nearestSpecials, q[0], q[1])).ToArray();
    }

    private static List<Special> CreateSpecials(int[] nums)
    {
        if (nums.Length < 2)
            return null;

        var specials = new List<Special> {new(0, nums[0] % 2 != nums[1] % 2)};

        for (var i = 1; i < nums.Length; i++)
        {
            var isDifferentParity = nums[i - 1] % 2 != nums[i] % 2;
            if (specials[^1].Value != isDifferentParity)
                specials.Add(new Special(i - 1, isDifferentParity));
            else
                specials[^1].To = i;
        }

        return specials;
    }

    private static int[] CreateNearestSpecials(List<Special> specials)
    {
        if (specials == null)
            return null;

        var n = specials[^1].To + 1;
        var nearestSpecials = new int[n];

        var specialIndex = 0;
        for (var i = 0; i < n; i++)
        {
            if (specials[specialIndex].To <= i)
                specialIndex++;
            nearestSpecials[i] = specialIndex;
        }

        return nearestSpecials;
    }

    private static bool IsSpecial(List<Special> specials, int[] nearestSpecials, int from, int to)
    {
        if (from == to)
            return true;

        var specialIndex = nearestSpecials[from];
        var special = specials[specialIndex];
        return special.Value && to <= special.To;
    }

    private class Special
    {
        public int From { get; set; }
        public int To { get; set; }
        public bool Value { get; set; }

        public Special(int from, bool value)
        {
            From = from;
            To = from + 1;
            Value = value;
        }

        public override string ToString() => $"[{From} - {To}] = {Value}";
    }
}
