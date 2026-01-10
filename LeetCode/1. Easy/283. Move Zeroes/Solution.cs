namespace LeetCode._1._Easy._283._Move_Zeroes;

public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        var nonZeroIndex = 0;
        for (var i = 0; i < nums.Length; i++)
            if (nums[i] != 0)
                nums[nonZeroIndex++] = nums[i];
        while (nonZeroIndex < nums.Length)
            nums[nonZeroIndex++] = 0;
    }
}
