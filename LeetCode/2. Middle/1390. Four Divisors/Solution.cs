using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._1390._Four_Divisors;

public class Solution
{
    private static readonly HashSet<int> excludedFourDivisorsNumbers = new(67008);
    private static readonly Dictionary<int, int> fourDivisorsNumbers = new(23334);

    static Solution()
    {
        CreateFourDivisorsNumbers();
    }

    public int SumFourDivisors(int[] nums)
    {
        return nums.Sum(x => fourDivisorsNumbers.GetValueOrDefault(x, 0));
    }

    private static void CreateFourDivisorsNumbers()
    {
        for (var i = 2; i <= 316; i++)
        {
            excludedFourDivisorsNumbers.Add(i * i);
            fourDivisorsNumbers.Remove(i * i);

            for (var j = i + 1; j <= 50_000; j++)
            {
                var fourDivisorNumber = i * j;

                if (fourDivisorNumber > 100_000)
                    break;

                if (excludedFourDivisorsNumbers.Contains(fourDivisorNumber))
                    continue;

                if (!fourDivisorsNumbers.TryAdd(fourDivisorNumber, 1 + i + j + fourDivisorNumber))
                {
                    excludedFourDivisorsNumbers.Add(fourDivisorNumber);
                    fourDivisorsNumbers.Remove(fourDivisorNumber);
                }
            }
        }
    }
}
