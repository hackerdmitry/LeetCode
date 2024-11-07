using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._2275._Largest_Combination_With_Bitwise_AND_Greater_Than_Zero;

public class Solution
{
    public int LargestCombination(int[] candidates)
    {
        var bitmap = new Dictionary<int, int>();
        foreach (var candidate in candidates)
            FillBitmap(bitmap, candidate);
        return bitmap.Values.Max();
    }

    private void FillBitmap(Dictionary<int, int> bitmap, int number)
    {
        for (var i = 0; number > 0; i++, number >>= 1)
            if (number % 2 == 1)
                bitmap[i] = bitmap.GetValueOrDefault(i, 0) + 1;
    }
}
