using System.Linq;

namespace LeetCode._2._Middle._2064._Minimized_Maximum_of_Products_Distributed_to_Any_Store;

public class Solution
{
    public int MinimizedMaximum(int n, int[] quantities)
    {
        var maxQuantity = quantities.Max();

        var left = 1;
        var right = maxQuantity;

        while (left < right)
        {
            var middle = (left + right) / 2;
            var distributionCount = CalculateDistributionCount(middle, quantities);

            if (distributionCount <= n)
                right = middle;
            else if (left == middle)
                left++;
            else
                left = middle;
        }

        return left;
    }

    private int CalculateDistributionCount(int packSize, int[] quantities)
    {
        var distributionCount = 0;
        foreach (var quantity in quantities)
        {
            var minDistributionCount = quantity / packSize;
            distributionCount += quantity % packSize == 0 ? minDistributionCount : minDistributionCount + 1;
        }

        return distributionCount;
    }
}