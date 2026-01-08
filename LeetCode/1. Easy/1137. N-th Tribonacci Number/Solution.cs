namespace LeetCode._1._Easy._1137._N_th_Tribonacci_Number;

public class Solution
{
    private readonly int[] dp = new int[38];

    public Solution()
    {
        dp[1] = 1;
        dp[2] = 1;
    }

    public int Tribonacci(int n)
    {
        if (n <= 2)
            return dp[n];
        if (dp[n] == 0)
            dp[n] = Tribonacci(n - 3) + Tribonacci(n - 2) + Tribonacci(n - 1);
        return dp[n];
    }
}
