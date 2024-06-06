using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._846._Hand_of_Straights;

public class Solution
{
    public bool IsNStraightHand(int[] hand, int groupSize)
    {
        if (hand.Length % groupSize != 0)
            return false;

        var sortedDictionary = new SortedDictionary<int, int>();
        foreach (var card in hand)
            if (!sortedDictionary.TryAdd(card, 1))
                sortedDictionary[card]++;

        var prevKey = -1;
        var toRemove = new List<int>(groupSize);
        var decrease = new List<int>(groupSize);
        while (sortedDictionary.Count >= groupSize)
        {
            foreach (var (key, value) in sortedDictionary.Take(groupSize))
            {
                if (prevKey != -1 && prevKey + 1 != key)
                    return false;

                if (value == 1)
                    toRemove.Add(key);
                else
                    decrease.Add(key);

                prevKey = key;
            }

            foreach (var key in toRemove)
                sortedDictionary.Remove(key);
            foreach (var key in decrease)
                sortedDictionary[key]--;

            toRemove.Clear();
            decrease.Clear();
            prevKey = -1;
        }

        return sortedDictionary.Count == 0;
    }
}