using System.Collections.Generic;
using LeetCode.__Additional;

namespace LeetCode._2._Middle._3217._Delete_Nodes_From_Linked_List_Present_in_Array;

public class Solution
{
    public ListNode ModifiedList(int[] nums, ListNode head)
    {
        var hashNums = new HashSet<int>(nums);
        while (head != null && hashNums.Contains(head.val))
            head = head.next;
        if (head == null)
            return null;

        var prev = head;
        var curr = head.next;
        while (curr != null)
        {
            if (hashNums.Contains(curr.val))
            {
                prev.next = curr.next;
                curr = prev;
            }

            prev = curr;
            curr = curr.next;
        }

        return head;
    }
}