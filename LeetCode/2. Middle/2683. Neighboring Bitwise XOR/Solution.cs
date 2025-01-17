using System.Linq;

namespace LeetCode._2._Middle._2683._Neighboring_Bitwise_XOR;

public class Solution
{
    public bool DoesValidArrayExist(int[] derived)
    {
        return derived.Count(x => x == 1) % 2 == 0;
    }
}
