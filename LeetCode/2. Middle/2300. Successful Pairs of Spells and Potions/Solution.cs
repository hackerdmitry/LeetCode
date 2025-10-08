using System;

namespace LeetCode._2._Middle._2300._Successful_Pairs_of_Spells_and_Potions;

public class Solution
{
    public int[] SuccessfulPairs(int[] spells, int[] potions, long success)
    {
        Array.Sort(potions);
        for (var i = 0; i < spells.Length; i++)
            spells[i] = potions.Length - BinarySearchMin(0, potions.Length, mid => (long) spells[i] * potions[mid] >= success);
        return spells;
    }

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
}