namespace LeetCode._2._Middle._2._Add_Two_Numbers
{
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var reversedResultNode = (ListNode)null;

            var inMind = 0;
            while (l1 != null || l2 != null)
            {
                var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + inMind;
                reversedResultNode = new ListNode(sum % 10, reversedResultNode);
                inMind = sum / 10;
                if (l1 != null) l1 = l1.next;
                if (l2 != null) l2 = l2.next;
            }

            if (inMind != 0)
                reversedResultNode = new ListNode(inMind, reversedResultNode);

            var resultNode = (ListNode)null;
            while (reversedResultNode != null)
            {
                resultNode = new ListNode(reversedResultNode.val, resultNode);
                reversedResultNode = reversedResultNode.next;
            }

            return resultNode;
        }
    }
}