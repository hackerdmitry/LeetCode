using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._1838._Frequency_of_the_Most_Frequent_Element;

public class Solution
{
    public int MaxFrequency(int[] nums, int k)
    {
        Array.Sort(nums);

        var slidingWindow = new Queue<int>();
        var curDiff = 0;
        var curK = 0;
        var maxFreq = 1;

        for (var i = 1; i < nums.Length; i++)
        {
            var newElemCost = (nums[i] - nums[i - 1]) * (slidingWindow.Count + 1);
            var predK = curK + newElemCost;
            if (predK <= k)
            {
                curK = predK;
                curDiff += nums[i] - nums[i - 1];
                slidingWindow.Enqueue(nums[i] - nums[i - 1]);
                if (slidingWindow.Count + 1 > maxFreq)
                    maxFreq = slidingWindow.Count + 1;
            }
            else
            {
                if (slidingWindow.Count == 0)
                    continue;

                curK -= curDiff;
                curDiff -= slidingWindow.Peek();
                slidingWindow.Dequeue();
                i--;
            }
        }

        return maxFreq;
    }

    // WRONG GROUPING VARIANT
    // public int MaxFrequency(int[] nums, int k)
    // {
    //     Array.Sort(nums);
    //
    //     var sums = new List<(int Value, int Sum, int MaxFreq)>();
    //     for (var i = 0; i < nums.Length; i++)
    //     {
    //         if (i != 0 && nums[i - 1] == nums[i])
    //             sums[^1] = (sums[^1].Value, 0, sums[^1].MaxFreq + 1);
    //         else
    //             sums.Add((nums[i], 0, 1));
    //     }
    //
    //     var lastLivingIndex = 0;
    //
    //     for (var i = 1; i < sums.Count; i++)
    //     {
    //         var diff = sums[i].Value - sums[i - 1].Value;
    //         for (var j = i - 1; j >= lastLivingIndex; j--)
    //         {
    //             var prediction = sums[j].Sum + diff * sums[j].MaxFreq;
    //             if (prediction > k)
    //             {
    //                 lastLivingIndex = j + 1;
    //                 break;
    //             }
    //
    //             sums[j] = (sums[j].Value, prediction, sums[j].MaxFreq + sums[i].MaxFreq);
    //         }
    //     }
    //
    //     return sums.Max(x => x.MaxFreq);
    // }

    // TIME LIMIT VARIANT BUT ABSOLUTELY CORRECT
    // public int MaxFrequency(int[] nums, int k)
    // {
    //     Array.Sort(nums);
    //
    //     var maxFreq = 1;
    //     var sums = Enumerable.Range(0, nums.Length).Select(_ => (Sum: 0, MaxFreq: 1)).ToArray();
    //     var lastLivingIndex = 0;
    //
    //     for (var i = 1; i < nums.Length; i++)
    //     {
    //         var diff = nums[i] - nums[i - 1];
    //         for (var j = i - 1; j >= lastLivingIndex; j--)
    //         {
    //             var prediction = sums[j].Sum + diff * sums[j].MaxFreq;
    //             if (prediction > k)
    //             {
    //                 lastLivingIndex = j + 1;
    //                 break;
    //             }
    //
    //             sums[j] = (prediction, sums[j].MaxFreq + 1);
    //             if (sums[j].MaxFreq > maxFreq)
    //                 maxFreq = sums[j].MaxFreq;
    //         }
    //     }
    //
    //     return maxFreq;
    // }
}