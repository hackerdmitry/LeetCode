using System.Collections.Generic;
using System.Linq;

namespace LeetCode._3._Hard._1931._Painting_a_Grid_With_Three_Different_Colors;

public class Solution
{
    private const int modulo = 1_000_000_007;

    public int ColorTheGrid(int m, int n)
    {
        var variantColors = GetVariantColors(-1, 0, m).ToArray();
        if (n == 1)
            return variantColors.Length;

        var map = CreateMap(variantColors, m);

        var dp1 = variantColors.ToDictionary(x => x, _ => 1);
        var dp2 = variantColors.ToDictionary(x => x, _ => 0);

        for (var i = 1; i < n; i++)
            if (i % 2 == 1)
                NextIteration(dp1, dp2, map);
            else
                NextIteration(dp2, dp1, map);

        return n % 2 == 0 ? Sum(dp2) : Sum(dp1);
    }

    private IEnumerable<int> GetVariantColors(int cur, int length, int maxLength)
    {
        var isLastRecursion = length + 1 == maxLength;
        var last = cur % 10;
        var nextPrefix = cur * 10;

        if (length == 0)
        {
            last = -1;
            nextPrefix = 0;
        }

        for (var i = 0; i < 3; i++)
            if (last != i)
                if (isLastRecursion)
                    yield return nextPrefix + i;
                else
                    foreach (var variantColor in GetVariantColors(nextPrefix + i, length + 1, maxLength))
                        yield return variantColor;
    }

    private Dictionary<int, int[]> CreateMap(int[] variantColors, int length)
    {
        return variantColors.ToDictionary(
            x => x,
            x => variantColors
                .Where(y => IsFit(x, y, length))
                .ToArray()
        );
    }

    private void NextIteration(Dictionary<int, int> dp1, Dictionary<int, int> dp2, Dictionary<int, int[]> map)
    {
        foreach (var (dp1Key, dp1Value) in dp1)
        {
            foreach (var possibleValue in map[dp1Key])
                dp2[possibleValue] = (dp2[possibleValue] + dp1Value) % modulo;
            dp1[dp1Key] = 0;
        }
    }

    private bool IsFit(int sequence1, int sequence2, int length)
    {
        while (length-- > 0)
        {
            var last1 = sequence1 % 10;
            sequence1 /= 10;
            var last2 = sequence2 % 10;
            sequence2 /= 10;
            if (last1 == last2)
                return false;
        }

        return true;
    }

    private int Sum(Dictionary<int, int> dp)
    {
        var result = 0;
        foreach (var value in dp.Values)
            result = (result + value) % modulo;
        return result;
    }
}