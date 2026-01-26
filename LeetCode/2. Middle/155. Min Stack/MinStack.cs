namespace LeetCode._2._Middle._155._Min_Stack;

public class MinStack
{
    private Node top;
    private Node minTop;

    public void Push(int val)
    {
        top = new Node(val, top);

        if (minTop == null || val <= minTop.Value)
            minTop = new Node(val, minTop);
    }

    public void Pop()
    {
        if (minTop != null && top.Value <= minTop.Value)
            minTop = minTop.Prev;
        top = top?.Prev;
    }

    public int Top()
    {
        return top.Value;
    }

    public int GetMin()
    {
        return minTop.Value;
    }

    private class Node
    {
        public Node Prev { get; }
        public int Value { get; }

        public Node(int value, Node prev)
        {
            Value = value;
            Prev = prev;
        }
    }
}