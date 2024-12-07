using System;
using System.Linq;

namespace LeetCode._2._Middle._1760._Minimum_Limit_of_Balls_in_a_Bag;

public class Solution
{
    public int MinimumSize(int[] nums, int maxOperations) =>
        BinarySearchMin(1, nums.Max(), targetValue => maxOperations >= CountOperations(nums, targetValue));

    private int BinarySearchMin(int left, int right, Func<int, bool> canBeRight)
    {
        while (left < right)
        {
            var mid = (left + right) / 2;
            var isRight = canBeRight(mid);
            if (isRight)
                right = mid;
            else if (left == mid)
                left++;
            else
                left = mid;
        }

        return left;
    }

    private int CountOperations(int[] nums, int targetValue) =>
        nums.Where(x => x > targetValue)
            .Sum(x => Ceil(x, targetValue) - 1);

    private int Ceil(int num1, int num2) =>
        num1 % num2 == 0
            ? num1 / num2
            : num1 / num2 + 1;
}