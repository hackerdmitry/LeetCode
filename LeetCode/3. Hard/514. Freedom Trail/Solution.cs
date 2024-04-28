using System;
using System.Linq;

namespace LeetCode._3._Hard._514._Freedom_Trail;

public class Solution
{
    public int FindRotateSteps(string ring, string key)
    {
        var dp = new int[key.Length, ring.Length];
        for (var i = 0; i < key.Length; i++)
            for (var j = 0; j < ring.Length; j++)
                if (key[i] == ring[j])
                    if (i == 0)
                        dp[i, j] = MinRotate(0, j, ring.Length) + 1;
                    else
                        for (var k = 0; k < ring.Length; k++)
                            if (key[i - 1] == ring[k])
                                dp[i, j] = dp[i, j] == 0
                                    ? dp[i - 1, k] + MinRotate(k, j, ring.Length) + 1
                                    : Math.Min(dp[i, j], dp[i - 1, k] + MinRotate(k, j, ring.Length) + 1);

        return Enumerable.Range(0, ring.Length)
            .Select(i => dp[key.Length - 1, i])
            .Where(x => x != 0)
            .Min();
    }

    private int MinRotate(int pos1, int pos2, int len)
    {
        return Math.Min(Math.Abs(pos1 - pos2), len - Math.Abs(pos1 - pos2));
    }
}