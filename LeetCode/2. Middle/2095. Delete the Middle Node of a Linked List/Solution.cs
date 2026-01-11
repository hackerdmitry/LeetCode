using LeetCode.__Additional;

namespace LeetCode._2._Middle._2095._Delete_the_Middle_Node_of_a_Linked_List;

public class Solution
{
    public ListNode DeleteMiddle(ListNode head)
    {
        var length = Count(head);
        if (length > 1)
        {
            Remove(head, length / 2);
            return head;
        }

        return null;
    }

    private void Remove(ListNode node, int offset)
    {
        while (--offset > 0)
            node = node.next;
        node.next = node.next.next;
    }

    private int Count(ListNode node)
    {
        var length = 0;
        while (node != null)
        {
            node = node.next;
            length++;
        }
        return length;
    }
}
