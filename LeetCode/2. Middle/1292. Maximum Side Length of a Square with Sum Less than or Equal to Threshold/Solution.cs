using System;

namespace LeetCode._2._Middle._1292._Maximum_Side_Length_of_a_Square_with_Sum_Less_than_or_Equal_to_Threshold;

public class Solution
{
    public int MaxSideLength(int[][] mat, int threshold)
    {
        var n = mat.Length;
        var m = mat[0].Length;

        var prefixSumRects = CreatePrefixSumRects(mat, n, m);
        var maxSide = 0;
        for (var y = 0; y < n; y++)
            for (var x = 0; x < m; x++)
                maxSide = Math.Max(maxSide, FindMaxSide(prefixSumRects, maxSide, y, x, threshold));

        return maxSide;
    }

    private int FindMaxSide(int[][] prefixSumRects, int left, int y, int x, int threshold)
    {
        return BinarySearchMax(left, Math.Min(y, x) + 1, side => CalculateArea(prefixSumRects, y, x, side) <= threshold);
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

    private static int[][] CreatePrefixSumRects(int[][] mat, int n, int m)
    {
        var prefixSumRects = new int[n][];
        for (var y = 0; y < n; y++)
            prefixSumRects[y] = new int[m];

        prefixSumRects[0][0] = mat[0][0];
        for (var y = 1; y < n; y++)
            prefixSumRects[y][0] = prefixSumRects[y - 1][0] + mat[y][0];
        for (var x = 1; x < m; x++)
            prefixSumRects[0][x] = prefixSumRects[0][x - 1] + mat[0][x];
        for (var x = 1; x < m; x++)
            for (var y = 1; y < n; y++)
                prefixSumRects[y][x] = mat[y][x] + prefixSumRects[y][x - 1] + prefixSumRects[y - 1][x] - prefixSumRects[y - 1][x - 1];
        return prefixSumRects;
    }

    private static int CalculateArea(int[][] prefixSumRects, int y, int x, int side)
    {
        if (side == 0)
            return 0;

        var y1 = y - side;
        var x1 = x - side;

        var leftArea = y1 < 0 ? 0 : prefixSumRects[y1][x];
        var rightArea = x1 < 0 ? 0 : prefixSumRects[y][x1];
        var angleArea = y1 < 0 || x1 < 0 ? 0 : prefixSumRects[y1][x1];

        return prefixSumRects[y][x] - leftArea - rightArea + angleArea;
    }
}