using System.Collections.Generic;

namespace LeetCode._2._Middle._3583._Count_Special_Triplets;

public class Solution
{
    private const int modulo = 1_000_000_007;

    public int SpecialTriplets(int[] nums)
    {
        var numPositions = new Dictionary<int, LinkedList<int>>();
        for (var i = 0; i < nums.Length; i++)
            Add(numPositions, i, nums[i]);

        var result = 0;
        foreach (var num in numPositions.Keys)
            if (num == 0)
                result = (result + CountZeros(numPositions[num].Count)) % modulo;
            else if (numPositions.ContainsKey(num * 2))
                result = (result + CountPairs(numPositions[num * 2], numPositions[num])) % modulo;

        return result;
    }

    private void Add(Dictionary<int, LinkedList<int>> numPositions, int pos, int num)
    {
        if (!numPositions.ContainsKey(num))
            numPositions[num] = new LinkedList<int>();
        numPositions[num].AddLast(pos);
    }

    private int CountPairs(LinkedList<int> parents, LinkedList<int> children)
    {
        if (parents.Count < 2)
            return 0;

        var parentNode = parents.First!;
        var childNode = children.First!;

        while (childNode != null && childNode.Value < parentNode.Value)
            childNode = childNode.Next;

        var intervals = new LinkedList<int>();
        while (parentNode.Next != null)
        {
            var interval = 0;
            parentNode = parentNode.Next;

            while (childNode != null && childNode.Value < parentNode.Value)
            {
                interval++;
                childNode = childNode.Next;
            }

            intervals.AddLast(interval);
        }

        return CountSumIntervals(intervals);
    }

    private int CountSumIntervals(LinkedList<int> intervals)
    {
        var localSum = 0L;
        var leftLength = intervals.Count;
        foreach (var interval in intervals)
            localSum += interval * leftLength--;

        var resultSum = 0L;
        leftLength = intervals.Count;
        foreach (var interval in intervals)
        {
            resultSum += localSum;
            localSum -= interval * leftLength--;
        }

        return (int) (resultSum % modulo);
    }

    private int CountZeros(int count)
    {
        count -= 2;
        var sum = 0;
        var currValue = 0;
        var currSum = 0;

        while (count-- > 0)
        {
            currSum = (currSum + ++currValue) % modulo;
            sum = (sum + currSum) % modulo;
        }

        return sum;
    }
}