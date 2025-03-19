namespace LeetCode._2._Middle._3191._Minimum_Operations_to_Make_Binary_Array_Elements_Equal_to_One_I;

public class Solution
{
    public int MinOperations(int[] nums)
    {
        var result = 0;
        for (var i = 0; i <= nums.Length - 3; i++)
            if (nums[i] == 0)
            {
                for (var j = i; j < i + 3; j++)
                    nums[j] = (nums[j] + 1) % 2;
                result++;
            }

        for (var i = nums.Length - 3; i < nums.Length; i++)
            if (nums[i] == 0)
                return -1;
        return result;
    }
}
