using System.Linq;

namespace LeetCode._1._Easy._724._Find_Pivot_Index;

public class Solution
{
    public int PivotIndex(int[] nums)
    {
        var leftSum = 0;
        var rightSum = nums.Sum();

        for (var i = 0; i < nums.Length; i++)
        {
            rightSum -= nums[i];
            if (leftSum == rightSum)
                return i;
            leftSum += nums[i];
        }

        return -1;
    }
}
