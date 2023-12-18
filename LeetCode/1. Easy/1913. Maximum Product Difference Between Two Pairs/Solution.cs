namespace LeetCode._1._Easy._1913._Maximum_Product_Difference_Between_Two_Pairs;

public class Solution
{
    public int MaxProductDifference(int[] nums)
    {
        var max1 = int.MinValue;
        var max2 = int.MinValue;

        var min1 = int.MaxValue;
        var min2 = int.MaxValue;

        foreach (var num in nums)
        {
            if (num > max1)
            {
                max2 = max1;
                max1 = num;
            } else if (num > max2)
                max2 = num;

            if (num < min1)
            {
                min2 = min1;
                min1 = num;
            } else if (num < min2)
                min2 = num;
        }

        return max1 * max2 - min1 * min2;
    }
}
