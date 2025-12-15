namespace LeetCode._2._Middle._2110._Number_of_Smooth_Descent_Periods_of_a_Stock;

public class Solution
{
    public long GetDescentPeriods(int[] prices)
    {
        var result = 0L;
        var startSmoothDescentIndex = 0;
        for (var i = 1; i < prices.Length; i++)
            if (prices[i] + 1 != prices[i - 1])
            {
                result += CountContiguous(i - startSmoothDescentIndex);
                startSmoothDescentIndex = i;
            }

        return result + CountContiguous(prices.Length - startSmoothDescentIndex);
    }

    private long CountContiguous(int n)
    {
        return (n + 1L) * n / 2L;
    }
}
