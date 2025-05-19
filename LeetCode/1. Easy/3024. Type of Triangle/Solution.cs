using System;

namespace LeetCode._1._Easy._3024._Type_of_Triangle;

public class Solution
{
    public string TriangleType(int[] nums)
    {
        Array.Sort(nums);

        if (nums[0] + nums[1] <= nums[2])
            return "none";

        if (nums[0] == nums[1] && nums[1] == nums[2])
            return "equilateral";

        return nums[0] != nums[1] && nums[1] != nums[2]
            ? "scalene"
            : "isosceles";
    }
}