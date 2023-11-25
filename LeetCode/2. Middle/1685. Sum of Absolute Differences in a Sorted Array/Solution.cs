using System.Linq;

namespace LeetCode._2._Middle._1685._Sum_of_Absolute_Differences_in_a_Sorted_Array;

public class Solution
{
    public int[] GetSumAbsoluteDifferences(int[] nums)
    {
        var leftSum = 0;
        var rightSum = nums.Sum();

        for (var i = 0; i < nums.Length; i++)
        {
            var num = nums[i];
            rightSum -= num;
            nums[i] = num * i - leftSum + rightSum - (nums.Length - 1 - i) * num;
            leftSum += num;
        }

        return nums;
    }
}
