using System.Linq;

namespace LeetCode._2._Middle._2483._Minimum_Penalty_for_a_Shop;

public class Solution
{
    public int BestClosingTime(string customers)
    {
        var result = 0;
        var currPenalty = customers.Count(x => x == 'Y');
        var minPenalty = currPenalty;

        for (var i = 0; i < customers.Length; i++)
            if ((currPenalty += customers[i] == 'N' ? 1 : -1) < minPenalty)
            {
                minPenalty = currPenalty;
                result = i + 1;
            }

        return result;
    }
}
