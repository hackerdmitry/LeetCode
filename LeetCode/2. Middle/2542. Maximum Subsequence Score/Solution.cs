using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._2542._Maximum_Subsequence_Score;

public class Solution
{
    public long MaxScore(int[] nums1, int[] nums2, int k)
    {
        var queue = new PriorityQueue<int, long>();

        var sum = 0L;
        var result = 0L;
        foreach (var (num1, num2) in nums1.Zip(nums2).OrderByDescending(x => x.Second))
            if (k-- > 0)
            {
                sum += num1;
                queue.Enqueue(num1, num1);
                if (k == 0)
                    result = sum * num2;
            }
            else if (num1 > queue.Peek())
            {
                sum += num1 - queue.Dequeue();
                queue.Enqueue(num1, num1);
                result = Math.Max(result, sum * num2);
            }

        return result;
    }
}