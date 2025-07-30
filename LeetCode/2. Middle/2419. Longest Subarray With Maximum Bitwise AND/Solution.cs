namespace LeetCode._2._Middle._2419._Longest_Subarray_With_Maximum_Bitwise_AND;

public class Solution
{
    public int LongestSubarray(int[] nums)
    {
        var maxNum = 0;
        var maxLength = 0;
        var currLength = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            currLength = i > 0 && nums[i - 1] != num ? 1 : currLength + 1;
            if (maxNum < num)
            {
                maxNum = num;
                maxLength = currLength;
            }
            if (maxNum == num && currLength > maxLength)
                maxLength = currLength;
        }

        return maxLength;
    }
}
