using System;

namespace LeetCode._2._Middle._2554._Maximum_Number_of_Integers_to_Choose_From_a_Range_I;

public class Solution
{
    public int MaxCount(int[] banned, int n, int maxSum)
    {
        Array.Sort(banned);

        var sum = 0;
        var result = 0;
        for (int i = 1, j = 0; i <= n; i++)
        {
            if (j < banned.Length && i == banned[j])
            {
                while (j < banned.Length && i == banned[j])
                    j++;
                continue;
            }

            sum += i;
            if (sum > maxSum)
                break;

            result++;
        }

        return result;
    }
}
