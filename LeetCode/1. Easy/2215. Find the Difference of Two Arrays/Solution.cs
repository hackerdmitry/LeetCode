using System.Collections.Generic;
using System.Linq;

namespace LeetCode._1._Easy._2215._Find_the_Difference_of_Two_Arrays;

public class Solution
{
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        return new IList<int>[]
        {
            nums1.Except(nums2).ToArray(),
            nums2.Except(nums1).ToArray(),
        };
    }
}
