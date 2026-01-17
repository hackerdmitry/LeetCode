using System.Collections.Generic;

namespace LeetCode._2._Middle._901._Online_Stock_Span;

public class StockSpanner
{
    private readonly Stack<(int Price, int Streak)> stack = new();

    public int Next(int price)
    {
        var streak = 1;
        while (stack.Count > 0 && stack.Peek().Price <= price)
            streak += stack.Pop().Streak;
        stack.Push((price, streak));
        return streak;
    }
}