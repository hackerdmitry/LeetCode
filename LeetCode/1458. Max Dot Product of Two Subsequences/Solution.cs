using System;

namespace LeetCode._1458._Max_Dot_Product_of_Two_Subsequences
{
    // Построение сетки:
    // "\t" + string.Join("\t", nums1) + Environment.NewLine + string.Join(Environment.NewLine, Enumerable.Range(0, nums2.Length).Select(i => nums2[i] + "\t" + string.Join("\t", Enumerable.Range(0, nums1.Length).Select(j => dp[i, j]))))

    public class Solution
    {
        public int MaxDotProduct(int[] nums1, int[] nums2)
        {
            var dp = new int?[nums2.Length, nums1.Length];
            var max = int.MinValue;

            for (var i = nums2.Length - 1; i >= 0; i--)
            {
                for (var j = nums1.Length - 1; j >= 0; j--)
                {
                    int? diffNum = null;
                    if (i != nums2.Length - 1)
                    {
                        for (int dj = j + 1; dj < nums1.Length; dj++)
                        {
                            if (diffNum == null)
                                diffNum = dp[i + 1, dj];
                            else
                                diffNum = Math.Max(diffNum.Value, dp[i + 1, dj].Value);
                        }
                    }

                    var potNum = nums2[i] * nums1[j];
                    dp[i, j] = diffNum == null
                        ? potNum
                        : potNum >= 0 && diffNum >= 0
                            ? potNum + diffNum
                            : Math.Max(potNum, diffNum.Value);
                    if (IsInBoundary(dp, i + 1, j))
                        dp[i, j] = Math.Max(dp[i, j].Value, dp[i + 1, j].Value);

                    max = Math.Max(max, dp[i, j].Value);
                }
            }

            return max;
        }

        private bool IsInBoundary(int?[,] dp, int i, int j)
        {
            return i >= 0 && i < dp.GetLength(0) &&
                   j >= 0 && j < dp.GetLength(1);
        }
    }
}