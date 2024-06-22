using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._1248._Count_Number_of_Nice_Subarrays;

public class Solution
{
    public int NumberOfSubarrays(int[] nums, int k)
    {
        var linkedList = new LinkedList<int>();
        linkedList.AddLast(1);

        foreach (var num in nums)
            if (num % 2 == 0)
                linkedList.Last.Value++;
            else
                linkedList.AddLast(1);

        if (linkedList.Count <= k)
            return 0;

        var start = linkedList.First;
        var end = start;
        while (k-- > 0)
            end = end.Next;

        var result = 0;
        while (end != null)
        {
            result += start.Value * end.Value;
            start = start.Next;
            end = end.Next;
        }

        return result;
    }
}