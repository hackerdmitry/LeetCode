using System.Linq;

namespace LeetCode._1._Easy._2099._Find_Subsequence_of_Length_K_With_the_Largest_Sum;

public class Solution
{
    public int[] MaxSubsequence(int[] nums, int k)
    {
        return nums
            .Select((x, i) => (x, i))
            .OrderByDescending(x => x.x)
            .ThenBy(x => x.i)
            .Take(k)
            .OrderBy(x => x.i)
            .Select(x => x.x)
            .ToArray();
    }
}