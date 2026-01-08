using System.Collections.Generic;
using System.Linq;

namespace LeetCode._1._Easy._1431._Kids_With_the_Greatest_Number_of_Candies;

public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        var maxCandies = candies.Max();
        return candies.Select(x => x + extraCandies >= maxCandies).ToArray();
    }
}
