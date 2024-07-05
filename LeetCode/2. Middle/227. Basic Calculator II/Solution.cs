using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode._2._Middle._227._Basic_Calculator_II;

public class Solution
{
    public int Calculate(string s)
    {
        var sb = new StringBuilder();
        foreach (var c in s)
            if (c != ' ')
                sb.Append(c);
        s = sb.ToString();

        var linkedList = new LinkedList<object>();

        var index = 0;
        linkedList.AddLast(ParseNumber(s, ref index));

        while (index < s.Length)
        {
            var lastOperation = s[index++];
            if (lastOperation is '*' or '/')
                linkedList.Last.Value = Calculate((int)linkedList.Last.Value, ParseNumber(s, ref index), lastOperation);
            else
            {
                linkedList.AddLast(lastOperation);
                linkedList.AddLast(ParseNumber(s, ref index));
            }
        }

        while (linkedList.Count > 1)
        {
            linkedList.First.Next.Value = Calculate((int)linkedList.First.Value, (int)linkedList.First.Next.Next.Value, (char)linkedList.First.Next.Value);
            linkedList.RemoveFirst();
            linkedList.Remove(linkedList.First.Next);
        }

        return (int)linkedList.First.Value;
    }

    private int ParseNumber(string s, ref int index)
    {
        var number = 0;

        while (char.IsDigit(s[index]))
        {
            number = number * 10 + s[index] - '0';
            index++;
            if (index == s.Length)
                break;
        }

        return number;
    }

    private int Calculate(int first, int second, char operation)
    {
        return operation switch
        {
            '+' => first + second,
            '-' => first - second,
            '*' => first * second,
            '/' => first / second,
            _ => throw new ArgumentOutOfRangeException(nameof(operation), operation, null),
        };
    }
}
