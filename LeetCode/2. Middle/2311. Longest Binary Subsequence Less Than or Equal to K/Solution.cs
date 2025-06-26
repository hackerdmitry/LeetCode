using System;

namespace LeetCode._2._Middle._2311._Longest_Binary_Subsequence_Less_Than_or_Equal_to_K;

public class Solution
{
    private const int limit = 1 << 30;

    public int LongestSubsequence(string s, int k)
    {
        return BinarySearchMax(0, s.Length, length => GetMinNumberByLength(s, length) <= k);
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

    private int GetMinNumberByLength(string s, int length)
    {
        var result = 0;
        for (var i = 0; i < s.Length && length > 0; i++)
            if (s[i] == '0' || s.Length - i == length)
            {
                result = (result << 1) + (s[i] - '0');
                if ((result & limit) == limit)
                    return limit;
                length--;
            }

        return result;
    }
}
