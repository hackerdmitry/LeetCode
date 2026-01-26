using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._150._Evaluate_Reverse_Polish_Notation;

public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();

        foreach (var token in tokens)
            switch (token)
            {
                case "+":
                    ApplyOperator(stack, (a, b) => a + b);
                    break;
                case "-":
                    ApplyOperator(stack, (a, b) => a - b);
                    break;
                case "/":
                    ApplyOperator(stack, (a, b) => a / b);
                    break;
                case "*":
                    ApplyOperator(stack, (a, b) => a * b);
                    break;
                default:
                    stack.Push(int.Parse(token));
                    break;
            }

        return stack.Pop();
    }

    private void ApplyOperator(Stack<int> stack, Func<int, int, int> operation)
    {
        var b = stack.Pop();
        var a = stack.Pop();
        stack.Push(operation(a, b));
    }
}