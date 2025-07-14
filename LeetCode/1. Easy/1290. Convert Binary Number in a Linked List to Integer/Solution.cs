using LeetCode.__Additional;

namespace LeetCode._1._Easy._1290._Convert_Binary_Number_in_a_Linked_List_to_Integer;

public class Solution
{
    public int GetDecimalValue(ListNode head)
    {
        var result = 0;
        while (head != null)
        {
            result = (result << 1) | head.val;
            head = head.next;
        }

        return result;
    }
}
