using System.Collections.Generic;

namespace LeetCode._2._Middle._912._Sort_an_Array;

public class Solution
{
    public int[] SortArray(int[] nums)
    {
        var node = SplitAndMergeSort(ToNode(nums), nums.Length);
        for (var i = 0; i < nums.Length; i++, node = node.Next)
            nums[i] = node.Value;
        return nums;
    }

    private Node ToNode(int[] nums)
    {
        Node result = null;
        Node last = null;

        for (var i = 0; i < nums.Length; i++)
        {
            var node = new Node(nums[i]) { Prev = last };
            if (last != null)
                last.Next = node;
            last = node;
            result ??= node;
        }

        return result;
    }

    private Node SplitAndMergeSort(Node first, int count)
    {
        if (count == 1)
            return first;

        var countSecond = count / 2;
        var countFirst = count - countSecond;
        return MergeSort(first, countFirst, GetNodeAfterSkip(first, countFirst), countSecond);
    }

    private Node MergeSort(
        Node first, int countFirst,
        Node second, int countSecond)
    {
        first = SplitAndMergeSort(first, countFirst);
        second = SplitAndMergeSort(second, countSecond);

        Node result = null;
        Node last = null;

        while (countFirst > 0 && countSecond > 0)
        {
            int toAddValue;
            if (first.Value < second.Value)
            {
                toAddValue = first.Value;
                first = first.Next;
                countFirst--;
            }
            else
            {
                toAddValue = second.Value;
                second = second.Next;
                countSecond--;
            }
            last = AddToNext(last, toAddValue);
            result ??= last;
        }

        while (countFirst > 0)
        {
            last = AddToNext(last, first.Value);
            first = first.Next;
            countFirst--;
        }

        while (countSecond > 0)
        {
            last = AddToNext(last, second.Value);
            second = second.Next;
            countSecond--;
        }

        return result;
    }

    private Node AddToNext(Node node, int toAddValue)
    {
        var toAddNode = new Node(toAddValue) { Prev = node };
        if (node != null)
            node.Next = toAddNode;
        return toAddNode;
    }

    private Node GetNodeAfterSkip(Node node, int skip)
    {
        while (skip-- > 0)
            node = node.Next;
        return node;
    }

    class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node Prev { get; set; }

        public Node(int value)
        {
            Value = value;
        }
    }
}