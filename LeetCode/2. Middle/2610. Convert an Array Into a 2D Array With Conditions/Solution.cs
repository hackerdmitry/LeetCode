using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._2610._Convert_an_Array_Into_a_2D_Array_With_Conditions;

public class Solution
{
    public IList<IList<int>> FindMatrix(int[] nums)
    {
        var result = new List<IList<int>> { new List<int>() };

        nums = nums.OrderBy(x => x).ToArray();
        var lastSameNumIndex = -1;
        for (var i = 0; i < nums.Length; i++)
        {
            if (lastSameNumIndex != -1 &&
                nums[lastSameNumIndex] == nums[i])
            {
                if (result.Count < i - lastSameNumIndex + 1)
                    result.Add(new List<int>());

                result[i - lastSameNumIndex].Add(nums[i]);
            }
            else
            {
                lastSameNumIndex = i;
                result[0].Add(nums[i]);
            }
        }

        return result;
    }
}
