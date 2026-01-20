namespace LeetCode._2._Middle._45._Jump_Game_II;

public class Solution
{
    public int Jump(int[] nums)
    {
        if (nums.Length == 1)
            return 0;

        var maxReach = 0;
        var dp = new int[nums.Length];
        for (var i = 0; i < nums.Length; i++)
            for (var j = maxReach + 1; j <= i + nums[i]; j++)
            {
                dp[j] = dp[i] + 1;
                maxReach = j;
                if (maxReach == nums.Length - 1)
                    return dp[j];
            }

        return 0;
    }
}
