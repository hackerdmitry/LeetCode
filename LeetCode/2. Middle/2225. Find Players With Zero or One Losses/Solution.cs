using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._2225._Find_Players_With_Zero_or_One_Losses;

public class Solution
{
    public IList<IList<int>> FindWinners(int[][] matches)
    {
        var notLostHash = new HashSet<int>();
        var oneLostHash = new HashSet<int>();
        var overLostHash = new HashSet<int>();

        foreach (var match in matches)
        {
            var winner = match[0];
            var loser = match[1];

            if (!notLostHash.Contains(winner) &&
                !oneLostHash.Contains(winner) &&
                !overLostHash.Contains(winner))
                notLostHash.Add(winner);

            if (notLostHash.Contains(loser))
            {
                notLostHash.Remove(loser);
                oneLostHash.Add(loser);
            }
            else if (oneLostHash.Contains(loser))
            {
                oneLostHash.Remove(loser);
                overLostHash.Add(loser);
            }
            else if (!overLostHash.Contains(loser))
                oneLostHash.Add(loser);
        }

        return new IList<int>[]
        {
            notLostHash.OrderBy(x => x).ToArray(),
            oneLostHash.OrderBy(x => x).ToArray()
        };
    }
}