using System.Collections.Generic;

namespace LeetCode._3._Hard._3510._Minimum_Pair_Removal_to_Sort_Array_II;

public class Solution
{
    public int MinimumPairRemoval(int[] nums)
    {
        var queue = new PriorityQueue<(LinkedListNode<PairState>, int), (long, int)>();
        var linkedList = new LinkedList<PairState>();
        var nonDecreasingCount = 0;

        for (var i = 1; i < nums.Length; i++)
        {
            var pairState = new PairState(i - 1, nums[i - 1], nums[i]);
            linkedList.AddLast(pairState);
            queue.Enqueue((linkedList.Last, pairState.GetIteration()), pairState.GetPriority());
            if (pairState.IsNonDecreasing)
                nonDecreasingCount++;
        }

        while (nonDecreasingCount != linkedList.Count)
        {
            var (pairStateNode, iteration) = queue.Dequeue();
            var currPair = pairStateNode.Value;
            if (iteration != currPair.GetIteration())
                continue;

            if (currPair.IsNonDecreasing)
                nonDecreasingCount--;

            var prevPair = pairStateNode.Previous?.Value;
            if (prevPair != null)
            {
                if (prevPair.AddRightNumber(currPair.RightNumber))
                    if (prevPair.IsNonDecreasing)
                        nonDecreasingCount++;
                    else
                        nonDecreasingCount--;
                queue.Enqueue((pairStateNode.Previous, prevPair.GetIteration()), prevPair.GetPriority());
            }

            var nextPair = pairStateNode.Next?.Value;
            if (nextPair != null)
            {
                if (nextPair.AddLeftNumber(currPair.LeftNumber))
                    if (nextPair.IsNonDecreasing)
                        nonDecreasingCount++;
                    else
                        nonDecreasingCount--;
                queue.Enqueue((pairStateNode.Next, nextPair.GetIteration()), nextPair.GetPriority());
            }

            linkedList.Remove(pairStateNode);
        }

        return nums.Length - (linkedList.Count + 1);
    }

    private class PairState
    {
        public long LeftNumber { get; private set; }
        public long RightNumber { get; private set; }

        public bool IsNonDecreasing => LeftNumber <= RightNumber;

        private readonly int index;
        private long sum;
        private int iteration;

        public PairState(int index, int leftNumber, int rightNumber)
        {
            this.index = index;
            LeftNumber = leftNumber;
            RightNumber = rightNumber;
            UpdateSum();
        }

        public bool AddLeftNumber(long number)
        {
            var prevIsNonDecreasing = IsNonDecreasing;
            LeftNumber += number;
            UpdateSum();
            return prevIsNonDecreasing != IsNonDecreasing;
        }

        public bool AddRightNumber(long number)
        {
            var prevIsNonDecreasing = IsNonDecreasing;
            RightNumber += number;
            UpdateSum();
            return prevIsNonDecreasing != IsNonDecreasing;
        }

        public int GetIteration()
        {
            return iteration;
        }

        private void UpdateSum()
        {
            sum = LeftNumber + RightNumber;
            iteration++;
        }

        public (long, int) GetPriority()
        {
            return (sum, index);
        }

        public override string ToString()
        {
            return $"{LeftNumber} > {sum} < {RightNumber}";
        }
    }
}
