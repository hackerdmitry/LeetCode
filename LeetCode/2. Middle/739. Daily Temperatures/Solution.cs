using System.Collections.Generic;

namespace LeetCode._2._Middle._739._Daily_Temperatures;

public class Solution
{
    public int[] DailyTemperatures(int[] temperatures)
    {
        var stack = new Stack<(int Temperature, int Index)>();
        var answer = new int[temperatures.Length];

        for (var i = 0; i < temperatures.Length; i++)
        {
            while (stack.Count > 0 && stack.Peek().Temperature < temperatures[i])
                answer[stack.Peek().Index] = i - stack.Pop().Index;
            stack.Push((temperatures[i], i));
        }

        return answer;
    }
}