namespace LeetCode.__Additional;

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    public static ListNode CreateFromArray(int[] input)
    {
        if (input == null || input.Length == 0)
            return null;

        var head = new ListNode(input[0]);
        var prevNode = head;
        for (var i = 1; i < input.Length; i++)
        {
            prevNode.next = new ListNode(input[i]);
            prevNode = prevNode.next;
        }

        return head;
    }
}