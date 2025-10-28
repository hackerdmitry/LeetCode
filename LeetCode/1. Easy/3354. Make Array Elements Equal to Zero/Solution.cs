using System.Linq;

namespace LeetCode._1._Easy._3354._Make_Array_Elements_Equal_to_Zero;

public class Solution
{
    public int CountValidSelections(int[] nums)
    {
        var left = 0;
        var right = nums.Sum();
        var result = 0;

        for (var curr = 0; curr < nums.Length; curr++)
        {
            if (nums[curr] == 0)
                if (left == right)
                    result += 2;
                else if (left + 1 == right || left == right + 1)
                    result++;
            left += nums[curr];
            right -= nums[curr];
        }

        return result;
    }
}
