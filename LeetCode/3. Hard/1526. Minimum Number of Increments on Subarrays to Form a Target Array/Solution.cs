using System.Collections.Generic;

namespace LeetCode._3._Hard._1526._Minimum_Number_of_Increments_on_Subarrays_to_Form_a_Target_Array;

public class Solution
{
    public int MinNumberOperations(int[] target)
    {
        var result = 0;
        var linkedList = new LinkedList<int>(target);
        while (linkedList.Count > 1)
        {
            var node = linkedList.First;
            while (node != null)
                if (!IsDependent(node) && linkedList.Count > 1)
                    result += node.Value - (node = Merge(linkedList, node)).Value;
                else
                    node = node.Next;
        }

        result += linkedList.First!.Value;
        return result;
    }

    private bool IsDependent(LinkedListNode<int> node) =>
        (node.Previous != null && node.Previous.Value > node.Value) ||
        (node.Next != null && node.Next.Value > node.Value);

    private LinkedListNode<int> Merge(LinkedList<int> linkedList, LinkedListNode<int> node)
    {
        var strongestDependentNode = node.Previous == null
            ? node.Next
            : node.Next == null
                ? node.Previous
                : node.Previous.Value > node.Next.Value
                    ? node.Previous
                    : node.Next;
        linkedList.Remove(node);
        return strongestDependentNode;
    }
}
