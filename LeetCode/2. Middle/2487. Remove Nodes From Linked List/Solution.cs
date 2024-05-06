using System.Collections;
using System.Collections.Generic;
using LeetCode.__Additional;

namespace LeetCode._2._Middle._2487._Remove_Nodes_From_Linked_List;

public class Solution
{
    public ListNode RemoveNodes(ListNode head)
    {
        var stack = new Stack<ListNode>();
        stack.Push(head);
        while (stack.Peek().next != null)
        {
            var next = stack.Peek().next;
            while (stack.Count > 0 && next.val > stack.Peek().val)
                stack.Pop();
            if (stack.Count == 0)
                head = next;
            else
                stack.Peek().next = next;
            stack.Push(next);
        }

        return head;
    }
}