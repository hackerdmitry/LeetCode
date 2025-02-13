using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._3066._Minimum_Operations_to_Exceed_Threshold_Value_II;

public class Solution
{
    public int MinOperations(int[] nums, int k)
    {
        var queue = new PriorityQueue<int, int>(nums.Where(x => x < k).Select(x => (x, x)));
        var countOperations = 0;
        while (queue.Count > 1)
        {
            countOperations++;
            var x = queue.Dequeue();
            var y = queue.Dequeue();
            var n = x * 2 + y;
            if (n < k && n > 0)
                queue.Enqueue(n, n);
        }

        return countOperations + queue.Count;
    }
}
