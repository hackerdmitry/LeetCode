namespace LeetCode._1._Easy._1464._Maximum_Product_of_Two_Elements_in_an_Array;

public class Solution
{
    public int MaxProduct(int[] nums)
    {
        var max1 = -1;
        var max2 = -1;

        for (var i = 0; i < nums.Length; i++)
        {
            if (max1 < nums[i])
            {
                max2 = max1;
                max1 = nums[i];
            }
            else if (max2 < nums[i])
                max2 = nums[i];
        }

        return (max1 - 1) * (max2 - 1);
    }
}
