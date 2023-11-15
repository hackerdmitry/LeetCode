using System.Linq;

namespace LeetCode._2._Middle._1846._Maximum_Element_After_Decreasing_and_Rearranging;

public class Solution
{
    public int MaximumElementAfterDecrementingAndRearranging(int[] arr)
    {
        arr = arr.OrderBy(x => x).ToArray();
        if (arr[0] > 1)
            arr[0] = 1;

        for (var i = 1; i < arr.Length; i++)
        {
            if (arr[i] - arr[i - 1] > 1)
            {
                arr[i] = arr[i - 1] + 1;
            }
        }

        return arr[^1];
    }
}
