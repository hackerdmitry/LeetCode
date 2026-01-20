using System;
using System.Collections.Generic;

namespace LeetCode._3._Hard._42._Trapping_Rain_Water;

public class Solution
{
    public int Trap(int[] height)
    {
        var leftStack = new Stack<int>();
        var leftMax = 0;
        var rightStack = new Stack<int>();
        var rightMax = 0;

        for (var i = 0; i < height.Length; i++)
            if (height[i] >= leftMax)
            {
                leftMax = height[i];
                leftStack.Push(i);
            }

        if (leftStack.Count == 0)
            return 0;

        var lastLeft = leftStack.Peek();
        for (var i = height.Length - 1; i >= lastLeft; i--)
            if (height[i] > rightMax)
            {
                rightMax = height[i];
                rightStack.Push(i);
            }

        return CalculateWaterArea(height, leftStack) + CalculateWaterArea(height, rightStack);
    }

    private int CalculateWaterArea(int[] height, Stack<int> barriers)
    {
        if (barriers.Count == 0)
            return 0;

        var area = 0;
        var right = barriers.Pop();
        while (barriers.Count > 0)
        {
            var left = barriers.Pop();
            area += CalculateWaterArea(height, left, right);
            right = left;
        }

        return area;
    }

    private int CalculateWaterArea(int[] height, int left, int right)
    {
        if (left > right)
            (left, right) = (right, left);

        var minHeight = Math.Min(height[left], height[right]);
        var area = 0;
        for (var i = left + 1; i < right; i++)
            area += Math.Max(0, minHeight - height[i]);
        return area;
    }
}