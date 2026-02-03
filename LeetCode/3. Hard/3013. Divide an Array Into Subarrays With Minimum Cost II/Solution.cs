using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._3._Hard._3013._Divide_an_Array_Into_Subarrays_With_Minimum_Cost_II;

public class Solution
{
    public long MinimumCost(int[] nums, int k, int dist)
    {
        if (k == 1)
            return nums[0];

        if (k == 2)
            return nums[0] + nums.Skip(1).Min();

        var costStore = new CostStore(k - 1);
        var minCost = long.MaxValue;

        for (var i = 1; i < nums.Length; i++)
        {
            costStore.Add(nums[i]);
            if (costStore.Length > dist + 1)
                costStore.Remove(nums[i - dist - 1]);
            minCost = Math.Min(minCost, costStore.Sum);
        }

        return minCost + nums[0];
    }

    private class CostStore
    {
        private readonly int smallMaxCount;
        private readonly SmallStore small = new();
        private readonly LargeStore large = new();

        public int Length { get; private set; }

        public CostStore(int smallMaxCount)
        {
            this.smallMaxCount = smallMaxCount;
        }

        public long Sum => small.Length == smallMaxCount ? small.Sum : long.MaxValue;

        public void Add(int value)
        {
            Length++;

            if (small.IsEmpty() || value <= small.GetMax())
                small.Add(value);
            else
                large.Add(value);

            if (small.Length > smallMaxCount)
                MoveFromSmallToLarge();
            else if (small.Length < smallMaxCount && !large.IsEmpty())
                MoveFromLargeToSmall();
        }

        public void Remove(int value)
        {
            Length--;

            if (small.TryRemove(value))
            {
                if (!large.IsEmpty())
                    MoveFromLargeToSmall();
            }
            else large.Remove(value);
        }

        private void MoveFromSmallToLarge()
        {
            var toMove = small.GetMax();
            small.TryRemove(toMove);
            large.Add(toMove);
        }

        private void MoveFromLargeToSmall()
        {
            var toMove = large.GetMin();
            large.Remove(toMove);
            small.Add(toMove);
        }
    }

    private class SmallStore
    {
        private readonly PriorityQueue<int, int> maxQueue = new();
        private readonly Dictionary<int, int> toRemoveInQueue = new();
        private readonly Dictionary<int, int> elements = new();

        public int Length { get; private set; }
        public long Sum { get; private set; }

        public bool IsEmpty() => elements.Count == 0;

        public int GetMax()
        {
            var value = maxQueue.Peek();
            while (toRemoveInQueue.ContainsKey(value))
            {
                maxQueue.Dequeue();
                if (--toRemoveInQueue[value] == 0)
                    toRemoveInQueue.Remove(value);
                value = maxQueue.Peek();
            }

            return value;
        }

        public void Add(int value)
        {
            if (!elements.TryAdd(value, 1))
                elements[value]++;
            Sum += value;
            Length++;
            maxQueue.Enqueue(value, -value);
        }

        public bool TryRemove(int value)
        {
            if (!elements.ContainsKey(value))
                return false;

            if (--elements[value] == 0)
                elements.Remove(value);

            if (!toRemoveInQueue.TryAdd(value, 1))
                toRemoveInQueue[value]++;

            Sum -= value;
            Length--;
            return true;
        }

        public bool Contains(int value) => elements.ContainsKey(value);
    }

    private class LargeStore
    {
        private readonly PriorityQueue<int, int> minQueue = new();
        private readonly Dictionary<int, int> toRemoveInQueue = new();
        private readonly Dictionary<int, int> elements = new();

        public bool IsEmpty() => elements.Count == 0;

        public int GetMin()
        {
            var value = minQueue.Peek();
            while (toRemoveInQueue.ContainsKey(value))
            {
                minQueue.Dequeue();
                if (--toRemoveInQueue[value] == 0)
                    toRemoveInQueue.Remove(value);
                value = minQueue.Peek();
            }

            return value;
        }

        public void Add(int value)
        {
            if (!elements.TryAdd(value, 1))
                elements[value]++;
            minQueue.Enqueue(value, value);
        }

        public void Remove(int value)
        {
            if (!elements.ContainsKey(value))
                return;

            if (--elements[value] == 0)
                elements.Remove(value);

            if (!toRemoveInQueue.TryAdd(value, 1))
                toRemoveInQueue[value]++;
        }
    }
}