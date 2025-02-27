using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._873._Length_of_Longest_Fibonacci_Subsequence;

public class Solution
{
    public int LenLongestFibSubseq(int[] arr)
    {
        var hashArr = arr.ToHashSet();
        var maxLenght = 0;
        for (var i = 0; i < arr.Length; i++)
            for (var j = i + 1; j < arr.Length; j++)
                maxLenght = Math.Max(GetLengthFibonacci(hashArr, arr[i], arr[j]), maxLenght);
        return maxLenght;
    }

    private int GetLengthFibonacci(HashSet<int> hashArr, int first, int second)
    {
        var length = 2;

        while (true)
        {
            (first, second) = (second, first + second);
            if (!hashArr.Contains(second))
                break;
            length++;
        }

        return length < 3 ? 0 : length;
    }
}