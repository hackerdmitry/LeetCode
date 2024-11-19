using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._2461._Maximum_Sum_of_Distinct_Subarrays_With_Length_K;

public class Solution
{
    public long MaximumSubarraySum(int[] nums, int k)
    {
        var differentNums = new DifferentNums();

        var sum = 0L;
        var maxSum = 0L;

        for (var i = 0; i < nums.Length; i++)
        {
            if (i >= k)
            {
                differentNums.RemoveNum(nums[i - k]);
                sum -= nums[i - k];
            }

            differentNums.AddNum(nums[i]);
            sum += nums[i];

            if (differentNums.CountDifferentNums == k)
                maxSum = Math.Max(maxSum, sum);
        }

        return maxSum;
    }

    private class DifferentNums
    {
        private readonly Dictionary<int, int> numsDictionary = new();

        public int CountDifferentNums { get; private set; }

        public void AddNum(int num)
        {
            if (!numsDictionary.TryAdd(num, 1))
                numsDictionary[num]++;

            switch (numsDictionary[num])
            {
                case 1:
                    CountDifferentNums++;
                    break;
                case 2:
                    CountDifferentNums--;
                    break;
            }
        }

        public void RemoveNum(int num)
        {
            if (!numsDictionary.ContainsKey(num))
                return;

            numsDictionary[num]--;

            switch (numsDictionary[num])
            {
                case 1:
                    CountDifferentNums++;
                    break;
                case 0:
                    CountDifferentNums--;
                    break;
            }
        }
    }
}
