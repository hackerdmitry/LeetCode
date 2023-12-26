using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCode._2._Middle._1155._Number_of_Dice_Rolls_With_Target_Sum;

public class Solution
{
    private const int module = 1_000_000_007;

    public int NumRollsToTarget(int n, int k, int target)
    {
        if (n * k < target)
            return 0;

        var n1 = new int[target];
        for (var i = Math.Max(0, target - k); i < target; i++)
            n1[i] = 1;

        var lastN1 = target - 1;
        var queue = new Queue<int>(k * 2 - 1);

        for (var i = 1; i < n; i++)
        {
            var sum = (long)n1[lastN1];
            queue.Enqueue(n1[lastN1]);
            n1[lastN1] = 0;

            for (var j = lastN1 - 1; queue.Count > 0 && j >= 0; j--)
            {
                var prevValue = n1[j];
                n1[j] = (int)(sum % module);

                if (queue.Count == k)
                    sum -= queue.Dequeue();

                if (n1[j] != 0)
                {
                    sum += prevValue;
                    queue.Enqueue(prevValue);
                }
            }

            queue.Clear();
            lastN1--;
        }

        return n1[0];
    }
}
