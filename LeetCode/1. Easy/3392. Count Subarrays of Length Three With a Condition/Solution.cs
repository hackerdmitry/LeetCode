using System.Linq;

namespace LeetCode._1._Easy._3392._Count_Subarrays_of_Length_Three_With_a_Condition;

public class Solution
{
    public int CountSubarrays(int[] nums)
    {
        return Enumerable.Range(1, nums.Length - 2).Count(i => nums[i] % 2 == 0 && nums[i] / 2 == nums[i - 1] + nums[i + 1]);
    }
}