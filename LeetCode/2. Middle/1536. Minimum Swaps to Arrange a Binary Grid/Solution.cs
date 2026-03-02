using System.Collections.Generic;

namespace LeetCode._2._Middle._1536._Minimum_Swaps_to_Arrange_a_Binary_Grid;

public class Solution
{
    public int MinSwaps(int[][] grid)
    {
        var result = 0;
        var linkedList = CreateLinkedList(grid);
        for (var target = grid.Length - 1; target >= 0; target--)
        {
            var node = linkedList.First;
            var distance = 0;
            while (node != null)
            {
                if (node.Value >= target)
                {
                    linkedList.Remove(node);
                    result += distance;
                    break;
                }

                node = node.Next;
                distance++;
            }

            if (node == null)
                return -1;
        }

        return result;
    }

    private LinkedList<int> CreateLinkedList(int[][] grid)
    {
        var linkedList = new LinkedList<int>();

        foreach (var row in grid)
            linkedList.AddLast(CountFitZeros(row));

        return linkedList;
    }

    private int CountFitZeros(int[] row)
    {
        for (var i = row.Length - 1; i >= 0; i--)
            if (row[i] == 1)
                return row.Length - 1 - i;

        return row.Length;
    }
}
