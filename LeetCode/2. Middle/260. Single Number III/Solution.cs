using System.Linq;

namespace LeetCode._2._Middle._260._Single_Number_III;

public class Solution
{
    public int[] SingleNumber(int[] nums)
    {
        return nums.GroupBy(x => x).Where(x => x.Count() == 1).Select(x => x.Key).ToArray();
    }
}
