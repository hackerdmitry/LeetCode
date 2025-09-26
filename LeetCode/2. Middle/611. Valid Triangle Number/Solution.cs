using System;

namespace LeetCode._2._Middle._611._Valid_Triangle_Number;

public class Solution
{
    public int TriangleNumber(int[] nums)
    {
        Array.Sort(nums);

        var result = 0;
        for (var i = 0; i < nums.Length; i++)
            for (var j = i + 1; j < nums.Length - 1; j++)
                if (IsFitTriangle(nums[i], nums[j], nums[j + 1]))
                    result += BinarySearchMax(j + 1, nums.Length - 1, k => IsFitTriangle(nums[i], nums[j], nums[k])) - j;

        return result;
    }

    private int BinarySearchMax(int left, int right, Func<int, bool> canBeLeft)
    {
        while (left < right)
        {
            var mid = (left + right) / 2;
            if (left == mid)
                mid++;
            var isLeft = canBeLeft(mid);
            if (isLeft)
                left = mid;
            else if (right == mid)
                right--;
            else
                right = mid;
        }

        return left;
    }

    private bool IsFitTriangle(int a, int b, int c) => c < a + b;
}