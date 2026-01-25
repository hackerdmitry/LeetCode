using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._3819._Rotate_Non_Negative_Elements;

public class Solution
{
    public int[] RotateElements(int[] nums, int k)
    {
        var countPositive = nums.Count(x => x >= 0);
        if (countPositive == 0)
            return nums;

        k %= countPositive;

        var firstPositiveIndex = -1;

        var queue = new Queue<int>();
        for (var i = nums.Length - 1; i >= 0; i--)
            if (nums[i] >= 0)
            {
                if (firstPositiveIndex == -1)
                    firstPositiveIndex = i;
                queue.Enqueue(nums[i]);
                if (queue.Count > k)
                    nums[i] = queue.Dequeue();
            }
        for (var i = nums.Length - 1; i >= 0 && queue.Count > 0; i--)
            if (nums[i] >= 0)
                nums[i] = queue.Dequeue();

        return nums;
    }
}