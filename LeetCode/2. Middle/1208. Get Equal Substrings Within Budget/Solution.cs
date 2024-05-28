using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._1208._Get_Equal_Substrings_Within_Budget;

public class Solution
{
    public int EqualSubstring(string s, string t, int maxCost)
    {
        var result = 0;

        var queue = new Queue<int>();
        var currentCost = 0;

        for (var i = 0; i < s.Length; i++)
        {
            var price = Math.Abs(s[i] - t[i]);
            queue.Enqueue(price);
            currentCost += price;

            while (currentCost > maxCost)
                currentCost -= queue.Dequeue();

            result = Math.Max(result, queue.Count);
        }

        return result;
    }
}