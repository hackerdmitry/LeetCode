namespace LeetCode._2._Middle._3818._Minimum_Prefix_Removal_to_Make_Array_Strictly_Increasing;

public class Solution
{
    public int MinimumPrefixLength(int[] nums)
    {
        var result = 1;
        for (var i = nums.Length - 2; i >= 0; i--)
            if (nums[i + 1] <= nums[i])
                break;
            else
                result++;
        return nums.Length - result;
    }
}