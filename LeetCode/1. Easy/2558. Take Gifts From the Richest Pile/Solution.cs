using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._1._Easy._2558._Take_Gifts_From_the_Richest_Pile;

public class Solution
{
    public long PickGifts(int[] gifts, int k)
    {
        var priorityQueue = new PriorityQueue<int, int>(gifts.Select(x => (x, -x)));
        for (var i = 0; i < k; i++)
        {
            var gift = priorityQueue.Dequeue();
            var newGift = (int) Math.Sqrt(gift);
            priorityQueue.Enqueue(newGift, -newGift);
        }

        return priorityQueue.UnorderedItems.Sum(x => (long)x.Element);
    }
}
