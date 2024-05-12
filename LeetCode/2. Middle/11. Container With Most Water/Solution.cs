using System;

namespace LeetCode._2._Middle._11._Container_With_Most_Water;

public class Solution
{
    public int MaxArea(int[] height)
    {
        var left = 0;
        var right = height.Length - 1;

        var maxArea = 0;
        while (left < right)
        {
            maxArea = Math.Max(maxArea, Math.Min(height[left], height[right]) * (right - left));
            if (height[right] > height[left])
                left++;
            else
                right--;
        }

        return maxArea;
    }
}