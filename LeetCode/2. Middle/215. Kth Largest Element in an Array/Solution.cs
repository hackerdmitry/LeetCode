using System.Collections.Generic;

namespace LeetCode._2._Middle._215._Kth_Largest_Element_in_an_Array;

public class Solution
{
    public int FindKthLargest(int[] nums, int k)
    {
        var queue = new PriorityQueue<int, int>(nums.Length);
        foreach (var num in nums)
            queue.Enqueue(num, -num);
        for (var i = 1; i < k; i++)
            queue.Dequeue();
        return queue.Dequeue();
    }
}
