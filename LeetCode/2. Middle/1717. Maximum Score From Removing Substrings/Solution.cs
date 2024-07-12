using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._1717._Maximum_Score_From_Removing_Substrings;

public class Solution
{
    public int MaximumGain(string s, int x, int y)
    {
        var a = 'a';
        var b = 'b';

        if (x < y)
        {
            (x, y) = (y, x);
            (a, b) = (b, a);
        }

        var score = 0;
        var stack = new Stack<char>(s.Length);

        foreach (var curr in s)
            if (stack.TryPeek(out var prev) && prev == a && curr == b)
            {
                stack.Pop();
                score += x;
            }
            else
                stack.Push(curr);

        if (stack.Count > 0)
        {
            var prev = stack.Pop();
            var streakA = prev == a ? 1 : 0;
            while (stack.Count > 0)
            {
                var curr = stack.Pop();
                if (curr == a)
                    streakA++;
                else if (curr == b && streakA > 0)
                {
                    streakA--;
                    score += y;
                }
                else
                    streakA = 0;
            }
        }

        return score;
    }
}
