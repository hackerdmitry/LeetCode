using System;

namespace LeetCode._2._Middle._2966._Divide_Array_Into_Arrays_With_Max_Difference;

public class Solution
{
    public int[][] DivideArray(int[] nums, int k)
    {
        Array.Sort(nums);
        for (var i = 0; i < nums.Length; i+=3)
            if (nums[i + 2] - nums[i] > k)
                return Array.Empty<int[]>();
        var result = new int[nums.Length / 3][];
        for (var i = 0; i < nums.Length; i += 3)
            result[i / 3] = new int[] {nums[i], nums[i + 1], nums[i + 2]};
        return result;
    }
}
