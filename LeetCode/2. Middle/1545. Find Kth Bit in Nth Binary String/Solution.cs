using System.Collections.Generic;

namespace LeetCode._2._Middle._1545._Find_Kth_Bit_in_Nth_Binary_String;

public class Solution
{
    public char FindKthBit(int n, int k)
    {
        var iteration = StartIteration();
        while (iteration.Count < k)
            NextIterate(iteration);
        return iteration[k - 1] ? '1' : '0';
    }

    private void NextIterate(List<bool> prevIteration)
    {
        var startCount = prevIteration.Count;
        prevIteration.Add(true);
        for (var i = startCount - 1; i >= 0; i--)
            prevIteration.Add(!prevIteration[i]);
    }

    private List<bool> StartIteration() =>
        new()
        {
            false, true, true, true, false, false, true, true, false, true, true, false, false, false, true,
        };
}