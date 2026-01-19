namespace LeetCode._1._Easy._26._Remove_Duplicates_from_Sorted_Array;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        var result = 1;
        for (var i = 1; i < nums.Length; i++)
            if (nums[i-1] != nums[i])
                nums[result++] = nums[i];
        return result;
    }
}
