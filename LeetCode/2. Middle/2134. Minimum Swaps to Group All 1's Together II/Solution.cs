using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._2134._Minimum_Swaps_to_Group_All_1_s_Together_II;

public class Solution
{
    public int MinSwaps(int[] nums)
    {
        var countOnes = nums.Count(x => x == 1);
        if (countOnes == 0)
            return 0;

        var queue = new Queue<int>();
        var currentZeros = 0;
        var currentIndex = 0;

        while (queue.Count != countOnes)
        {
            var num = nums[currentIndex++];
            queue.Enqueue(num);
            if (num == 0)
                currentZeros++;
        }

        var minSwaps = currentZeros;

        for (var i = countOnes; i < nums.Length; i++)
        {
            if (queue.Dequeue() == 0)
                currentZeros--;
            queue.Enqueue(nums[i]);
            if (nums[i] == 0)
                currentZeros++;
            minSwaps = Math.Min(minSwaps, currentZeros);
        }

        for (var i = 0; i < countOnes; i++)
        {
            if (queue.Dequeue() == 0)
                currentZeros--;
            queue.Enqueue(nums[i]);
            if (nums[i] == 0)
                currentZeros++;
            minSwaps = Math.Min(minSwaps, currentZeros);
        }

        return minSwaps;
    }
}