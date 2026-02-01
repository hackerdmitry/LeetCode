using System.Linq;

namespace LeetCode._1._Easy._3010._Divide_an_Array_Into_Subarrays_With_Minimum_Cost_I;

public class Solution
{
    public int MinimumCost(int[] nums)
    {
        return nums[0] + nums.Skip(1).OrderBy(x => x).Take(2).Sum();
    }
}
