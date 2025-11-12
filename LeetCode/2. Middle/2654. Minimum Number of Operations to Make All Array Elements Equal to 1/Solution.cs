using System;
using System.Linq;

namespace LeetCode._2._Middle._2654._Minimum_Number_of_Operations_to_Make_All_Array_Elements_Equal_to_1;

public class Solution
{
    public int MinOperations(int[] nums)
    {
        var onesCount = nums.Count(x => x == 1);
        if (onesCount > 0)
            return nums.Length - onesCount;

        for (var n = 1; n < nums.Length; n++)
        {
            var maxGcd = int.MinValue;
            var minGcd = int.MaxValue;

            for (var i = 0; i < nums.Length - n; i++)
            {
                var gcd = Gcd(nums[i], nums[i + 1]);
                if (gcd == 1)
                    return nums.Length - 1 + n;
                nums[i] = gcd;
                maxGcd = Math.Max(maxGcd, gcd);
                minGcd = Math.Min(minGcd, gcd);
            }

            if (maxGcd == minGcd)
                return -1;
        }

        return -1;
    }

    private int Gcd(int num1, int num2)
    {
        while (num1 != 0 && num2 != 0)
            if (num1 > num2)
                num1 %= num2;
            else
                num2 %= num1;

        return Math.Max(num1, num2);
    }
}
