using System.Linq;

namespace LeetCode._1._Easy._3289._The_Two_Sneaky_Numbers_of_Digitville;

public class Solution
{
    public int[] GetSneakyNumbers(int[] nums)
    {
        return nums.GroupBy(x => x).Where(x => x.Count() > 1).Select(x => x.Key).OrderBy(x => x).ToArray();
    }
}
