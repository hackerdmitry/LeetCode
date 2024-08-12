using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._1._Easy._703._Kth_Largest_Element_in_a_Stream;

public class KthLargest
{
    private readonly PriorityQueue<int, int> priorityQueue = new();
    private readonly int k = 0;

    public KthLargest(int k, int[] nums)
    {
        Array.Sort(nums);
        this.k = k;
        priorityQueue.EnqueueRange(nums.Skip(nums.Length - k).Select(x => (x, GetPriority(x))));
    }

    public int Add(int val)
    {
        if (priorityQueue.Count < k)
        {
            priorityQueue.Enqueue(val, GetPriority(val));
            return priorityQueue.Peek();
        }

        if (priorityQueue.Peek() >= val)
            return priorityQueue.Peek();

        priorityQueue.EnqueueDequeue(val, GetPriority(val));
        return priorityQueue.Peek();
    }

    private int GetPriority(int val) => val;
}