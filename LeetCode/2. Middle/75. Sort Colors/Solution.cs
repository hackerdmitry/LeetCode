namespace LeetCode._2._Middle._75._Sort_Colors;

public class Solution
{
    public void SortColors(int[] nums)
    {
        for (var i = 0; i < nums.Length; i++)
            for (var j = i + 1; j < nums.Length; j++)
                if (nums[i] > nums[j])
                    (nums[i], nums[j]) = (nums[j], nums[i]);
    }
}