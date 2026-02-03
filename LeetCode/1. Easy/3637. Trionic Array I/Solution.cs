namespace LeetCode._1._Easy._3637._Trionic_Array_I;

public class Solution
{
    public bool IsTrionic(int[] nums)
    {
        var index = 1;
        return IsIncreasing(nums, ref index) && IsDecreasing(nums, ref index) && IsIncreasing(nums, ref index) && index == nums.Length;
    }

    private bool IsIncreasing(int[] nums, ref int index)
    {
        if (index < nums.Length && nums[index - 1] < nums[index])
        {
            index++;
            while (index < nums.Length && nums[index - 1] < nums[index])
                index++;
            return true;
        }

        return false;
    }

    private bool IsDecreasing(int[] nums, ref int index)
    {
        if (index < nums.Length && nums[index - 1] > nums[index])
        {
            index++;
            while (index < nums.Length && nums[index - 1] > nums[index])
                index++;
            return true;
        }

        return false;
    }
}
