using System.Collections.Generic;
using System.Linq;

namespace LeetCode._3._Hard._1411._Number_of_Ways_to_Paint_N___3_Grid;

public class Solution
{
    private const int modulo = 1_000_000_007;

    public int NumOfWays(int n)
    {
        var same = 6L;
        var diff = 6L;

        while (--n > 0)
        {
            (same, diff) = NextState(same, diff);
        }

        return (int)((same + diff) % modulo);
    }

    private (long same, long diff) NextState(long same, long diff)
    {
        return (
            (same * 3 + diff * 2) % modulo,
            (same * 2 + diff * 2) % modulo
        );
    }
}