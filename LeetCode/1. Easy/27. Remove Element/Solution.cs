namespace LeetCode._1._Easy._27._Remove_Element;

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        var result = 0;
        for (var i = 0; i < nums.Length; i++)
            if (nums[i] != val)
                nums[result++] = nums[i];
        return result;
    }
}
