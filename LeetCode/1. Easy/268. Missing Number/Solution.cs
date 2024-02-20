namespace LeetCode._1._Easy._268._Missing_Number;

public class Solution
{
    public int MissingNumber(int[] nums)
    {
        var unknown = nums.Length;
        for (var i = 0; i < nums.Length; i++)
        {
            while (nums[i] != i)
            {
                if (nums[i] == nums.Length)
                {
                    unknown = i;
                    nums[i] = -1;
                    break;
                }

                (nums[nums[i]], nums[i]) = (nums[i], nums[nums[i]]);
                if (nums[i] == -1)
                {
                    unknown = i;
                    break;
                }
            }
        }

        return unknown;
    }
}