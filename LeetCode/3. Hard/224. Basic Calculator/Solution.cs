using System.Collections.Generic;

namespace LeetCode._3._Hard._224._Basic_Calculator;

public class Solution
{
    private readonly Queue<LinkedListNode<IToken>>[] operationsQueue = {new(), new(), new()};

    public int Calculate(string s)
    {
        var tokens = new LinkedList<IToken>();
        var stack = new Stack<LinkedListNode<IToken>>();
        for (var i = 0; i < s.Length; i++)
        {
            next: ;

            if (s[i] == ' ')
                continue;

            if (char.IsDigit(s[i]))
            {
                var result = s[i] - '0';
                while (++i < s.Length && char.IsDigit(s[i]))
                    result = result * 10 + (s[i] - '0');
                tokens.AddLast(new NumberToken(result));
                if (i == s.Length)
                    break;
                goto next;
            }

            if (s[i] == '(')
            {
                stack.Push(tokens.Last);
                continue;
            }

            if (s[i] == ')')
            {
                Calculate(tokens, stack.Pop()?.Next ?? tokens.First);
                continue;
            }

            var isUnary = tokens.Last?.Value is not NumberToken;
            tokens.AddLast(new OperationToken(s[i], isUnary));
        }

        if (tokens.Count > 1)
            Calculate(tokens, tokens.First);

        return (tokens.First!.Value as NumberToken)!.Value;
    }

    private void Calculate(LinkedList<IToken> tokens, LinkedListNode<IToken> from)
    {
        var node = from;
        while (node != null)
        {
            if (node.Value is OperationToken operationToken)
                operationsQueue[operationToken.GetPriority()].Enqueue(node);
            node = node.Next;
        }

        for (var i = 0; i < operationsQueue.Length; i++)
            while (operationsQueue[i].Count > 0)
                Apply(tokens, operationsQueue[i].Dequeue());
    }

    private void Apply(LinkedList<IToken> tokens, LinkedListNode<IToken> node)
    {
        if (node?.Value is not OperationToken operationNode)
            return;

        var isUnary = operationNode.IsUnary;
        var nextNumber = (node.Next!.Value as NumberToken)!;
        if (isUnary)
        {
            if (operationNode.Value == '-')
                nextNumber.Negate();
        }
        else
        {
            var prevNumber = (node.Previous!.Value as NumberToken)!;
            if (operationNode.Value == '+')
                prevNumber.Add(nextNumber.Value);
            else if (operationNode.Value == '-')
                prevNumber.Subtract(nextNumber.Value);
            else if (operationNode.Value == '*')
                prevNumber.Multiply(nextNumber.Value);
            else if (operationNode.Value == '/')
                prevNumber.Divide(nextNumber.Value);
            tokens.Remove(node.Next);
        }

        tokens.Remove(node);
    }

    private class OperationToken : IToken
    {
        public char Value { get; }
        public bool IsUnary { get; }

        public OperationToken(char value, bool isUnary)
        {
            Value = value;
            IsUnary = isUnary;
        }

        public int GetPriority()
        {
            if (IsUnary)
                return 0;

            return Value switch
            {
                '*' or '/' => 1,
                '+' or '-' => 2,
            };
        }
    }

    private class NumberToken : IToken
    {
        public int Value { get; private set; }

        public NumberToken(int value)
        {
            Value = value;
        }

        public void Add(int value) => Value += value;

        public void Subtract(int value) => Value -= value;

        public void Multiply(int value) => Value *= value;

        public void Divide(int value) => Value /= value;

        public void Negate() => Value = -Value;
    }

    private interface IToken { }
}