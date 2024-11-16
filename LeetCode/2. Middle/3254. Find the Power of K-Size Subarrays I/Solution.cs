namespace LeetCode._2._Middle._3254._Find_the_Power_of_K_Size_Subarrays_I;

public class Solution
{
    public int[] ResultsArray(int[] nums, int k)
    {
        if (k == 1)
            return nums;

        var result = new int[nums.Length - k + 1];
        var consecutiveCount = 1;

        for (var i = 1; i < nums.Length; i++)
        {
            if (nums[i - 1] + 1 == nums[i])
                consecutiveCount++;
            else
                consecutiveCount = 1;

            if (i >= k - 1)
                result[i - k + 1] = consecutiveCount >= k ? nums[i] : -1;
        }

        return result;
    }
}