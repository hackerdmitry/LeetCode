using System.Collections.Generic;

namespace LeetCode._2._Middle._3811._Number_of_Alternating_XOR_Partitions;

public class Solution
{
    private const int modulo = 1_000_000_007;

    public int AlternatingXOR(int[] nums, int target1, int target2)
    {
        var n = nums.Length;
        var px = new int[n];
        px[0] = nums[0];

        for (var i = 1; i < n; i++)
            px[i] = px[i - 1] ^ nums[i];

        var dp0 = new int[n];
        var dp1 = new int[n];

        var sum0 = new Dictionary<int, int>();
        var sum1 = new Dictionary<int, int>();

        for (var i = 0; i < n; i++)
        {
            var need0 = px[i] ^ target1;
            var need1 = px[i] ^ target2;

            dp0[i] = sum1.ContainsKey(need0) ? sum1[need0] : 0;
            dp1[i] = sum0.ContainsKey(need1) ? sum0[need1] : 0;

            if (px[i] == target1)
                dp0[i] = (dp0[i] + 1) % modulo;

            if (!sum0.ContainsKey(px[i])) sum0[px[i]] = 0;
            if (!sum1.ContainsKey(px[i])) sum1[px[i]] = 0;

            sum0[px[i]] = (sum0[px[i]] + dp0[i]) % modulo;
            sum1[px[i]] = (sum1[px[i]] + dp1[i]) % modulo;
        }

        return (int) (((long) dp0[n - 1] + dp1[n - 1]) % modulo);
    }
}