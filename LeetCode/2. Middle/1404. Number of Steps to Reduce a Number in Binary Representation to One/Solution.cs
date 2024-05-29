using System.Collections.Generic;

namespace LeetCode._2._Middle._1404._Number_of_Steps_to_Reduce_a_Number_in_Binary_Representation_to_One;

public class Solution
{
    public int NumSteps(string s)
    {
        var number = ToNumber(s);
        var counter = 0;
        while (number.Count != 1)
        {
            if (number.Last.Value)
                AddOne(number);
            else
                DivideByTwo(number);

            counter++;
        }

        return counter;
    }

    private LinkedList<bool> ToNumber(string s)
    {
        var result = new LinkedList<bool>();
        foreach (var c in s)
            result.AddLast(c == '1');
        return result;
    }

    private void DivideByTwo(LinkedList<bool> number)
    {
        number.RemoveLast();
    }

    private void AddOne(LinkedList<bool> number)
    {
        var node = number.Last;
        while (node is { Value: true })
        {
            node.Value = false;
            node = node.Previous;
        }

        if (node == null)
            number.AddFirst(true);
        else
            node.Value = true;
    }
}
