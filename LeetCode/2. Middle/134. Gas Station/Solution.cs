using System.Linq;

namespace LeetCode._2._Middle._134._Gas_Station;

public class Solution
{
    public int CanCompleteCircuit(int[] gas, int[] cost)
    {
        var n = gas.Length;
        var result = new int[n];
        for (var i = 0; i < n; i++)
            result[i] = gas[i] - cost[i];
        if (result.Sum() < 0)
            return -1;

        var left = 0;
        var sum = 0;
        for (var right = 0; right < n; right++)
        {
            sum += result[right];
            while (sum < 0 && left <= right)
            {
                sum -= result[left];
                left++;
            }
        }

        return left;
    }
}
