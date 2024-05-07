using LeetCode.__Additional;

namespace LeetCode._2._Middle._2816._Double_a_Number_Represented_as_a_Linked_List;

public class Solution
{
    public ListNode DoubleIt(ListNode head)
    {
        var array = new ListNode[10_000];
        array[0] = head;
        var length = 1;
        for (; array[length - 1].next != null; length++)
            array[length] = array[length - 1].next;

        var remainder = 0;
        for (var i = length - 1; i >= 0; i--)
        {
            array[i].val += array[i].val + remainder;
            remainder = array[i].val / 10;
            array[i].val %= 10;
        }

        return remainder == 0 ? head : new ListNode(remainder, head);
    }
}