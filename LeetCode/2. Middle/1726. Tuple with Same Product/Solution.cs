using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._1726._Tuple_with_Same_Product;

public class Solution
{
    public int TupleSameProduct(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
            for (var j = i + 1; j < nums.Length; j++)
            {
                var mult = nums[i] * nums[j];
                if (!dict.TryAdd(mult, 1))
                    dict[mult]++;
            }

        return dict.Values.Where(x => x > 1).Sum(x => 4 * x * (x - 1));
    }
}