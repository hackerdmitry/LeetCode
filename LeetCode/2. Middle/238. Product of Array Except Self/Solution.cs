using System.Linq;

namespace LeetCode._2._Middle._238._Product_of_Array_Except_Self;

public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var product = 1;
        var countZeros = 0;

        for (var i = 0; i < nums.Length; i++)
            if (nums[i] == 0)
                countZeros++;
            else
                product *= nums[i];

        for (var i = 0; i < nums.Length; i++)
            if (countZeros >= 2)
                nums[i] = 0;
            else if (countZeros == 1)
                nums[i] = nums[i] == 0 ? product : 0;
            else
                nums[i] = product / nums[i];

        return nums;
    }
}