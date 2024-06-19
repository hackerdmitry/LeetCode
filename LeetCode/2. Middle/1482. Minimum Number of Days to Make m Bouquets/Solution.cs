using System.Linq;

namespace LeetCode._2._Middle._1482._Minimum_Number_of_Days_to_Make_m_Bouquets;

public class Solution
{
    public int MinDays(int[] bloomDay, int m, int k)
    {
        if ((long)m * k > bloomDay.Length)
            return -1;

        var left = 0;
        var right = bloomDay.Max();

        while (left < right)
        {
            var mid = (left + right) / 2;
            var canMakeBouquets = CheckBloom(mid, bloomDay, m, k);
            if (canMakeBouquets)
                right = mid;
            else if (left == mid)
                left++;
            else
                left = mid;
        }

        return left;
    }

    private bool CheckBloom(int day, int[] bloomDay, int m, int k)
    {
        var count = 0;
        foreach (var bloom in bloomDay)
        {
            if (bloom <= day)
                count++;
            else
                count = 0;

            if (count == k)
            {
                count = 0;
                m--;
            }

            if (m == 0)
                return true;
        }

        return false;
    }
}