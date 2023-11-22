using System.Collections.Generic;

namespace LeetCode._2._Middle._1424._Diagonal_Traverse_II;

public class Solution
{
    public int[] FindDiagonalOrder(IList<IList<int>> nums)
    {
        var preparedNums = new LinkedList<(LinkedListNode<int>, LinkedList<int>)>();
        foreach (var rowNums in nums)
        {
            var rowPreparedNums = new LinkedList<int>(rowNums);
            preparedNums.AddLast((rowPreparedNums.First, rowPreparedNums));
        }

        var result = new List<int>();

        var start = preparedNums.First;
        while (preparedNums.Count > 0)
        {
            var next = start.Next;
            var current = start;

            while (current != null)
            {
                var (curNode, rowPreparedNums) = current.Value;
                result.Add(curNode.Value);
                var previous = current.Previous;
                if (curNode.Next == null)
                {
                    if (start == current)
                        start = start.Previous;
                    preparedNums.Remove(current.Value);
                }
                else
                    current.Value = (curNode.Next, rowPreparedNums);
                current = previous;
            }

            if (next != null)
                start = next;
        }

        return result.ToArray();
    }
}
