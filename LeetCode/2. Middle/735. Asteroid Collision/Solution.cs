using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._735._Asteroid_Collision;

public class Solution
{
    public int[] AsteroidCollision(int[] asteroids)
    {
        var stack = new Stack<int>();

        foreach (var asteroid in asteroids)
            if (stack.Count == 0 || Math.Sign(stack.Peek()) == -1 || Math.Sign(asteroid) == 1)
                stack.Push(asteroid);
            else
            {
                while (stack.Count > 0 && Math.Sign(stack.Peek()) == 1 && stack.Peek() < -asteroid)
                    stack.Pop();
                if (stack.Count > 0 && Math.Sign(stack.Peek()) == 1 && stack.Peek() == -asteroid)
                    stack.Pop();
                else if (stack.Count == 0 || Math.Sign(stack.Peek()) == -1)
                    stack.Push(asteroid);
            }

        var result = new int[stack.Count];
        for (var i = stack.Count - 1; i >= 0; i--)
            result[i] = stack.Pop();
        return result;
    }
}
