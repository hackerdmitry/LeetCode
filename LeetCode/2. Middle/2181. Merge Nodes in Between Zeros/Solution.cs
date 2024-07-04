using LeetCode.__Additional;

namespace LeetCode._2._Middle._2181._Merge_Nodes_in_Between_Zeros;

public class Solution
{
    public ListNode MergeNodes(ListNode head)
    {
        head = head.next;

        var node = head;
        while (node != null)
        {
            var prev = node.next;
            node.val += prev.val;
            node.next = prev.next;
            if (prev.val == 0)
                node = node.next;
        }

        return head;
    }
}
