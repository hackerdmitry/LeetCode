using LeetCode.__Additional;

namespace LeetCode._1._Easy._206._Reverse_Linked_List;

public class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        if (head?.next == null)
            return head;

        var nextNode = head.next;
        var node = head;
        head.next = null;

        while (nextNode != null)
        {
            var futureNextNode = nextNode.next;
            nextNode.next = node;
            node = nextNode;
            nextNode = futureNextNode;
        }

        return node;
    }
}
