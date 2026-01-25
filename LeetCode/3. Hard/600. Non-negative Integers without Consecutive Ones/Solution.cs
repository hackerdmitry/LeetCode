namespace LeetCode._3._Hard._600._Non_negative_Integers_without_Consecutive_Ones;

public class Solution
{
    public int FindIntegers(int n)
    {
        if (n == 0)
            return 1;

        var countBits = CountBits(n);
        var dp = CreateDP(countBits);
        return CountMax(n, dp);
    }

    private static int[][] CreateDP(int countBits)
    {
        var dp = new int[countBits][];
        dp[0] = new[] {1, 1};
        for (var i = 1; i < countBits; i++)
            dp[i] = new[]
            {
                dp[i - 1][0] + dp[i - 1][1],
                dp[i - 1][0],
            };
        return dp;
    }

    private int CountBits(int n)
    {
        var count = 0;
        while (n > 0)
        {
            n >>= 1;
            count++;
        }

        return count;
    }

    private int CountMax(int n, int[][] dp)
    {
        var result = 0;
        var prevBit = 0;
        var countBits = dp.Length;

        for (var i = countBits - 1; i >= 0; i--)
        {
            var bit = (n >> i) & 1;
            if (bit == 1)
            {
                result += dp[i][0];
                if (prevBit == 1)
                    return result;
            }

            prevBit = bit;
        }

        return result + 1;
    }
}