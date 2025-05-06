using System.Linq;

namespace LeetCode._1._Easy._1920._Build_Array_from_Permutation;

public class Solution
{
    public int[] BuildArray(int[] nums)
    {
        return nums.Select(i => nums[i]).ToArray();
    }
}
