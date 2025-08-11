using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._2438._Range_Product_Queries_of_Powers;

public class Solution
{
    private const long modulo = 1_000_000_007;

    public int[] ProductQueries(int n, int[][] queries)
    {
        var powers = GetPowers(n);
        return queries.Select(x => GetQueryResult(x, powers)).ToArray();
    }

    private int[] GetPowers(int n)
    {
        var powers = new List<int>(30);
        for (var helpNum = 1; helpNum < modulo; helpNum <<= 1)
            if ((n & helpNum) > 0)
                powers.Add(helpNum);
        return powers.ToArray();
    }

    private int GetQueryResult(int[] query, int[] powers)
    {
        var result = (long)powers[query[0]];
        for (var i = query[0] + 1; i <= query[1]; i++)
            result = result * powers[i] % modulo;
        return (int) result;
    }
}
