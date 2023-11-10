using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._1743._Restore_the_Array_From_Adjacent_Pairs;

public class Solution
{
    public int[] RestoreArray(int[][] adjacentPairs)
    {
        var pairs = new Dictionary<int, HashSet<int>>();
        foreach (var adjacentPair in adjacentPairs.Skip(1))
        {
            if (pairs.ContainsKey(adjacentPair[0]))
                pairs[adjacentPair[0]].Add(adjacentPair[1]);
            else
                pairs[adjacentPair[0]] = new HashSet<int> { adjacentPair[1] };

            if (pairs.ContainsKey(adjacentPair[1]))
                pairs[adjacentPair[1]].Add(adjacentPair[0]);
            else
                pairs[adjacentPair[1]] = new HashSet<int> { adjacentPair[0] };
        }

        var result = new LinkedList<int>();
        result.AddLast(adjacentPairs[0][0]);
        result.AddLast(adjacentPairs[0][1]);

        for (var i = 1; i < adjacentPairs.Length; i++)
        {
            var isFromLast = pairs.ContainsKey(result.Last.Value) && pairs[result.Last.Value].Count != 0;
            var cur = isFromLast ? result.Last.Value : result.First.Value;
            var next = pairs[cur].First();
            pairs[cur].Remove(next);
            pairs[next].Remove(cur);

            if (isFromLast)
                result.AddLast(next);
            else
                result.AddFirst(next);
        }

        return result.ToArray();
    }
}
