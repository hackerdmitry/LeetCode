using System.Collections.Generic;

namespace LeetCode._2._Middle._3542._Minimum_Operations_to_Convert_All_Elements_to_Zero;

public class Solution
{
    public int MinOperations(int[] nums)
    {
        var stack = new Stack<int>();
        var result = 0;
        foreach (var num in nums)
        {
            if (num == 0)
            {
                stack.Clear();
                continue;
            }

            while (stack.Count > 0 && stack.Peek() > num)
                stack.Pop();

            if (stack.Count == 0 || stack.Peek() < num)
            {
                stack.Push(num);
                result++;
            }
        }

        return result;
    }
}
