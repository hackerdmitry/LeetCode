namespace LeetCode._1._Easy._3379._Transformed_Array;

public class Solution
{
    public int[] ConstructTransformedArray(int[] nums)
    {
        var result = new int[nums.Length];
        for (var i = 0; i < nums.Length; i++)
            result[i] = nums[(i + 100 * nums.Length + nums[i]) % nums.Length];
        return result;
    }
}
