using LeetCode.__Additional;

namespace LeetCode._2._Middle._328._Odd_Even_Linked_List;

public class Solution
{
    public ListNode OddEvenList(ListNode head)
    {
        if (head == null)
            return head;

        var node = head;
        var tail = GetTail(head, out var count);

        count /= 2;
        while (count-- > 0)
        {
            var prevNode = node;
            tail = tail.next = node = node.next;
            prevNode.next = node.next;
            node.next = null;
            node = prevNode.next;
        }

        return head;
    }

    private ListNode GetTail(ListNode node, out int count)
    {
        count = 1;
        while (node.next != null)
        {
            node = node.next;
            count++;
        }
        return node;
    }
}