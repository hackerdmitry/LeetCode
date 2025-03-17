using System.Linq;

namespace LeetCode._1._Easy._2206._Divide_Array_Into_Equal_Pairs;

public class Solution
{
    public bool DivideArray(int[] nums)
    {
        return nums.GroupBy(x => x).All(x => x.Count() % 2 == 0);
    }
}
