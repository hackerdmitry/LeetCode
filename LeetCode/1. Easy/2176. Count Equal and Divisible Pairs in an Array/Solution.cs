namespace LeetCode._1._Easy._2176._Count_Equal_and_Divisible_Pairs_in_an_Array;

public class Solution
{
    public int CountPairs(int[] nums, int k)
    {
        var result = 0;
        for (var i = 0; i < nums.Length; i++)
            for (var j = i + 1; j < nums.Length; j++)
                if (nums[i] == nums[j] && i * j % k == 0)
                    result++;
        return result;
    }
}
