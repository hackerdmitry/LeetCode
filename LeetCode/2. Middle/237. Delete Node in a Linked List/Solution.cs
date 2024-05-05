using LeetCode.__Additional;

namespace LeetCode._2._Middle._237._Delete_Node_in_a_Linked_List;

public class Solution
{
    public void DeleteNode(ListNode node)
    {
        node.val = node.next.val;
        node.next = node.next.next;
    }
}