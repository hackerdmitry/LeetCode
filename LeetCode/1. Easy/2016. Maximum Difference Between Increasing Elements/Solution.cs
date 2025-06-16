namespace LeetCode._1._Easy._2016._Maximum_Difference_Between_Increasing_Elements;

public class Solution
{
    public int MaximumDifference(int[] nums)
    {
        var result = -1;
        var localMin = int.MaxValue;

        foreach (var num in nums)
            if (num <= localMin)
                localMin = num;
            else if (num - localMin > result)
                result = num - localMin;

        return result;
    }
}
