using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._3814._Maximum_Capacity_Within_Budget;

public class Solution
{
    public int MaxCapacity(int[] costs, int[] capacities, int budget)
    {
        budget--;

        var maxCapacity = 0;

        var n = costs.Length;
        var bestCapacities = new IncreasingSortedDictionary();
        foreach (var (cost, capacity) in Enumerable.Range(0, n).Select(i => (Cost: costs[i], Capacity: capacities[i])).OrderBy(x => x.Cost).ThenByDescending(x => x.Capacity))
            if (cost <= budget)
            {
                var bestCapacity = capacity + (bestCapacities.FindPrevOrEqual(budget - cost)?.Value ?? 0);
                maxCapacity = Math.Max(maxCapacity, bestCapacity);
                bestCapacities.Add(cost, capacity);
            }

        return maxCapacity;
    }

    private class IncreasingSortedDictionary
    {
        private List<int> keys = new();
        private Dictionary<int, int> dictionary = new();

        public void Add(int key, int value)
        {
            if (keys.Count > 0 && dictionary[keys[^1]] >= value)
                return;

            dictionary[key] = value;
            if (keys.Count == 0 || keys[^1] != key)
                keys.Add(key);
        }

        public (int Key, int Value)? FindPrevOrEqual(int key)
        {
            if (keys.Count == 0 || keys[0] > key)
                return null;

            var index = BinarySearchMax(0, keys.Count - 1, mid => keys[mid] <= key);
            return (keys[index], dictionary[keys[index]]);
        }

        private int BinarySearchMax(int left, int right, Func<int, bool> canBeLeft)
        {
            while (left < right)
            {
                var mid = (left + right) / 2;
                if (left == mid)
                    mid++;
                var isLeft = canBeLeft(mid);
                if (isLeft)
                    left = mid;
                else if (right == mid)
                    right--;
                else
                    right = mid;
            }

            return left;
        }
    }
}