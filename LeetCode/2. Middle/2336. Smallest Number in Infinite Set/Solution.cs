using System.Collections.Generic;

namespace LeetCode._2._Middle._2336._Smallest_Number_in_Infinite_Set;

public class SmallestInfiniteSet
{
    private readonly HashSet<int> backedNumsBag = new();
    private readonly PriorityQueue<int, int> backedNums = new();
    private int smallestNum = 1;

    public int PopSmallest()
    {
        return backedNums.Count > 0
            ? DequeueBackedNum()
            : smallestNum++;
    }

    public void AddBack(int num)
    {
        if (smallestNum > num && backedNumsBag.Add(num))
            backedNums.Enqueue(num, num);
    }

    private int DequeueBackedNum()
    {
        var num = backedNums.Dequeue();
        backedNumsBag.Remove(num);
        return num;
    }
}