using LeetCode.__Additional;

namespace LeetCode._2._Middle._82._Remove_Duplicates_from_Sorted_List_II;

public class Solution
{
    public ListNode DeleteDuplicates(ListNode head)
    {
        while (head?.next != null && head.val == head.next.val)
        {
            var toRemoveVal = head.val;
            while (head != null && head.val == toRemoveVal)
                head = head.next;
        }

        var node = head;
        while (node?.next?.next != null)
        {
            if (node.next.val == node.next.next.val)
            {
                var toRemoveVal = node.next.val;
                while (node.next != null && node.next.val == toRemoveVal)
                    node.next = node.next.next;
            }
            else
                node = node.next;
        }

        return head;
    }
}
