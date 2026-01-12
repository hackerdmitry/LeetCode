using System.Linq;
using LeetCode.__Additional;

namespace LeetCode._2._Middle._2130._Maximum_Twin_Sum_of_a_Linked_List;

public class Solution
{
    public int PairSum(ListNode head)
    {
        var count = Count(head);
        var twinSums = new int[count / 2];
        var node = head;
        for (var i = 0; i < count / 2; i++, node = node.next)
            twinSums[i] = node.val;
        for (var i = count / 2 - 1; i >= 0; i--, node = node.next)
            twinSums[i] += node.val;
        return twinSums.Max();
    }

    private int Count(ListNode node)
    {
        var length = 1;
        while (node.next != null)
        {
            length++;
            node = node.next;
        }
        return length;
    }
}
