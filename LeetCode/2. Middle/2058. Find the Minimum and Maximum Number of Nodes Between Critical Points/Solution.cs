using System;
using LeetCode.__Additional;

namespace LeetCode._2._Middle._2058._Find_the_Minimum_and_Maximum_Number_of_Nodes_Between_Critical_Points;

public class Solution
{
    public int[] NodesBetweenCriticalPoints(ListNode head)
    {
        var maxDistance = -1;
        var minDistance = -1;

        var prevCriticalPoint = -1;

        var prev = head;
        head = head.next;

        while (head.next != null)
        {
            if (prev.val > head.val && head.val < head.next.val ||
                prev.val < head.val && head.val > head.next.val)
            {
                if (prevCriticalPoint != -1)
                {
                    maxDistance = maxDistance == -1 ? prevCriticalPoint : maxDistance + prevCriticalPoint;
                    minDistance = minDistance == -1 ? prevCriticalPoint : Math.Min(minDistance, prevCriticalPoint);
                }

                prevCriticalPoint = 0;
            }

            if (prevCriticalPoint != -1)
                prevCriticalPoint++;

            prev = head;
            head = head.next;
        }

        return new[]{minDistance, maxDistance};
    }
}
