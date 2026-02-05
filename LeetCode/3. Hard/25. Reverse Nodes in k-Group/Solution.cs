using LeetCode.__Additional;

namespace LeetCode._3._Hard._25._Reverse_Nodes_in_k_Group;

public class Solution
{
    public ListNode ReverseKGroup(ListNode head, int k)
    {
        var node = head;
        if (ThereIsExistsKNodes(head, k))
        {
            head = ReverseK(head, k);

            while (ThereIsExistsKNodes(node.next, k))
            {
                var next = node.next;
                node.next = ReverseK(node.next, k);
                node = next;
            }
        }

        return head;
    }

    private ListNode ReverseK(ListNode node, int k)
    {
        var prev = (ListNode) null;
        var next = (ListNode) null;
        var current = node;

        while (k-- > 0)
        {
            next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }

        node.next = next;
        return prev;
    }

    private bool ThereIsExistsKNodes(ListNode node, int k)
    {
        while (k-- > 0 && node != null)
            node = node.next;

        return k < 0;
    }
}
