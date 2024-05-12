using System.Collections.Generic;
using LeetCode.__Additional;

namespace LeetCode._2._Middle._19._Remove_Nth_Node_From_End_of_List;

public class Solution
{
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var queue = new Queue<ListNode>();
        var limit = n + 1;
        var node = head;
        while (node != null)
        {
            queue.Enqueue(node);
            if (queue.Count > limit)
                queue.Dequeue();
            node = node.next;
        }

        if (queue.Count == n)
            return head.next;

        queue.Dequeue().next = queue.Dequeue().next;
        return head;
    }
}