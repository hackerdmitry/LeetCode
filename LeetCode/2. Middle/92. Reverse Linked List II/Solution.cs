using LeetCode.__Additional;

namespace LeetCode._2._Middle._92._Reverse_Linked_List_II;

public class Solution
{
    public ListNode ReverseBetween(ListNode head, int left, int right)
    {
        if (left == 1)
            return Reverse(head, right);

        ListNode prev = null;
        var current = head;
        while (--left > 0)
        {
            prev = current;
            current = current.next;
            right--;
        }

        prev.next = Reverse(current, right);
        return head;
    }

    private ListNode Reverse(ListNode head, int count)
    {
        ListNode prev = null;
        ListNode next = null;
        var current = head;

        while (count-- > 0)
        {
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        head.next = next;
        return prev;
    }
}
