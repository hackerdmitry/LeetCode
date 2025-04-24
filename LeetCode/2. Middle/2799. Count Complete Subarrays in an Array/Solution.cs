namespace LeetCode._2._Middle._2799._Count_Complete_Subarrays_in_an_Array;

public class Solution
{
    public int CountCompleteSubarrays(int[] nums)
    {
        var countNums = new int[2000];
        foreach (var num in nums)
            countNums[num - 1]++;

        var right = nums.Length;

        for (; right > 1 && countNums[nums[right - 1] - 1] > 1; countNums[nums[--right] - 1]--) ;

        var result = 0;
        for (var left = 0; left < nums.Length; countNums[nums[left++] - 1]--)
        {
            result += nums.Length - right + 1;

            while (countNums[nums[left] - 1] == 1)
            {
                if (right == nums.Length)
                    return result;
                countNums[nums[right++] - 1]++;
            }
        }

        return result;
    }
}