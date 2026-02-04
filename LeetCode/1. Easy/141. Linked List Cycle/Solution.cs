using System.Collections.Generic;
using LeetCode.__Additional;

namespace LeetCode._1._Easy._141._Linked_List_Cycle;

public class Solution
{
    public bool HasCycle(ListNode head)
    {
        var visited = new HashSet<ListNode>();
        var current = head;
        while (current != null)
        {
            if (!visited.Add(current))
                return true;
            current = current.next;
        }

        return false;
    }
}
