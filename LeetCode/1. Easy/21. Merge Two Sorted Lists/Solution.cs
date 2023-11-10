namespace LeetCode._1._Easy._21._Merge_Two_Sorted_Lists
{
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            var elem1 = list1;
            var elem2 = list2;

            var reversedResult = (ListNode)null;
            while (elem1 != null || elem2 != null)
            {
                if (elem1 == null)
                {
                    reversedResult = new ListNode(elem2.val, reversedResult);
                    elem2 = elem2.next;
                }
                else if (elem2 == null)
                {
                    reversedResult = new ListNode(elem1.val, reversedResult);
                    elem1 = elem1.next;
                }
                else
                {
                    if (elem1.val < elem2.val)
                    {
                        reversedResult = new ListNode(elem1.val, reversedResult);
                        elem1 = elem1.next;
                    }
                    else
                    {
                        reversedResult = new ListNode(elem2.val, reversedResult);
                        elem2 = elem2.next;
                    }
                }
            }

            var result = (ListNode) null;
            while (reversedResult != null)
            {
                result = new ListNode(reversedResult.val, result);
                reversedResult = reversedResult.next;
            }

            return result;
        }
    }
}