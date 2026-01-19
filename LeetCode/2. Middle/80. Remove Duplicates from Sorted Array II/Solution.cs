namespace LeetCode._2._Middle._80._Remove_Duplicates_from_Sorted_Array_II;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length <= 2)
            return nums.Length;

        var result = 0;
        for (var i = 0; i < nums.Length; i++)
            if (i >= nums.Length - 2 || nums[i] != nums[i + 1] || nums[i] != nums[i + 2])
                nums[result++] = nums[i];
        return result;
    }
}