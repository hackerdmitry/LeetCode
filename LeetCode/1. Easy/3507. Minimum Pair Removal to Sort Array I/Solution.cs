using System.Collections.Generic;

namespace LeetCode._1._Easy._3507._Minimum_Pair_Removal_to_Sort_Array_I;

public class Solution
{
    public int MinimumPairRemoval(int[] nums)
    {
        var numsNodes = new LinkedList<int>(nums);
        while (numsNodes.Count > 1)
        {
            var minSumNode = numsNodes.First!;
            var minSum = int.MaxValue;
            var decreasingCount = 0;

            var node = numsNodes.First!.Next;
            while (node != null)
            {
                var sum = node.Previous!.Value + node.Value;
                if (sum < minSum)
                {
                    minSum = sum;
                    minSumNode = node;
                }

                if (node.Previous!.Value > node.Value)
                    decreasingCount++;

                node = node.Next;
            }

            if (decreasingCount== 0)
                break;

            minSumNode.Value += minSumNode.Previous!.Value;
            numsNodes.Remove(minSumNode.Previous);
        }

        return nums.Length - numsNodes.Count;
    }
}
