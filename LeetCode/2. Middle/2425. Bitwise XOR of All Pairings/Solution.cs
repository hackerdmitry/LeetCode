using System.Linq;

namespace LeetCode._2._Middle._2425._Bitwise_XOR_of_All_Pairings;

public class Solution
{
    public int XorAllNums(int[] nums1, int[] nums2)
    {
        var enumerable = Enumerable.Empty<int>();
        if (nums1.Length % 2 == 1)
            enumerable = enumerable.Concat(nums2);
        if (nums2.Length % 2 == 1)
            enumerable = enumerable.Concat(nums1);
        return enumerable.Aggregate(0, (result, curr) => result ^ curr);
    }
}
