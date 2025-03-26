using System;

namespace LeetCode._2._Middle._2033._Minimum_Operations_to_Make_a_Uni_Value_Grid;

public class Solution
{
    public int MinOperations(int[][] grid, int x)
    {
        var m = grid.Length;
        var n = grid[0].Length;
        var anyNum = grid[0][0];
        var nums = new int[m * n];
        var numsIndex = 0;
        for (var i = 0; i < m; i++)
            for (var j = 0; j < n; j++)
            {
                var num = grid[i][j];
                if ((anyNum - num) % x != 0)
                    return -1;
                nums[numsIndex++] = num;
            }
        Array.Sort(nums);

        return nums.Length % 2 == 1
            ? CountOperations(nums, nums[nums.Length / 2], x)
            : Math.Min(
                CountOperations(nums, nums[nums.Length / 2 - 1], x),
                CountOperations(nums, nums[nums.Length / 2], x)
            );
    }

    private int CountOperations(int[] nums, int target, int x)
    {
        var result = 0;
        foreach (var num in nums)
            result += Math.Abs(target - num) / x;

        return result;
    }
}
