using System;

namespace LeetCode._2._Middle._3719._Longest_Balanced_Subarray_I;

public class Solution
{
    public int LongestBalanced(int[] nums)
    {
        var balanceManager = new BalanceManager();
        for (var i = 0; i < nums.Length; i += 2)
        {
            for (var j = i; j < nums.Length; j++)
                balanceManager.Add(nums[j]);

            balanceManager.Remove(nums[i]);
            for (var j = nums.Length - 1; j > i; j--)
                balanceManager.Remove(nums[j]);
        }

        return balanceManager.MaxBalancedCount;
    }

    private class BalanceManager
    {
        public int MaxBalancedCount { get; private set; }

        private int[] NumberCounts { get; } = new int[100000];
        private int EvenCount { get; set; }
        private int OddCount { get; set; }
        private int Count { get; set; }

        public void Add(int number)
        {
            NumberCounts[number - 1]++;
            Count++;
            if (NumberCounts[number - 1] == 1)
                if (number % 2 == 0)
                    EvenCount++;
                else
                    OddCount++;

            TryToUpdateMaxBalancedCount();
        }

        public void Remove(int number)
        {
            NumberCounts[number - 1]--;
            Count--;
            if (NumberCounts[number - 1] == 0)
                if (number % 2 == 0)
                    EvenCount--;
                else
                    OddCount--;

            TryToUpdateMaxBalancedCount();
        }

        private void TryToUpdateMaxBalancedCount()
        {
            if (EvenCount == OddCount)
                MaxBalancedCount = Math.Max(MaxBalancedCount, Count);
        }
    }
}