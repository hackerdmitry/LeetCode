using System;

namespace LeetCode._1793._Maximum_Score_of_a_Good_Subarray
{
    public class Solution
    {
        public int MaximumScore(int[] nums, int k)
        {
            var a = new int[k + 1];
            var b = new int[nums.Length - k];

            var minA = int.MaxValue;
            for (int i = k; i >= 0; i--)
            {
                if (nums[i] < minA)
                    minA = nums[i];

                a[i] = minA;
            }

            var minB = int.MaxValue;
            for (int i = k; i < nums.Length; i++)
            {
                if (nums[i] < minB)
                    minB = nums[i];

                b[i - k] = minB;
            }

            var aIndex = 0;
            var bIndex = nums.Length - k - 1;
            var maxScore = Math.Min(a[aIndex], b[bIndex]) * (bIndex + k + 1);

            while (aIndex != k || bIndex != 0)
            {
                var min = Math.Min(a[aIndex], b[bIndex]);
                var score = min * (bIndex + k - aIndex + 1);
                if (score > maxScore)
                    maxScore = score;

                if (aIndex == k)
                    bIndex--;
                else if (bIndex == 0)
                    aIndex++;
                else
                {
                    if (a[aIndex] < b[bIndex])
                        aIndex++;
                    else
                        bIndex--;
                }
            }

            return maxScore;
        }
    }
}