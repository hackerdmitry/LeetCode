using System.Linq;

namespace LeetCode._3._Hard._2551._Put_Marbles_in_Bags;

public class Solution
{
    public long PutMarbles(int[] weights, int k)
    {
        var pairs = Enumerable.Range(0, weights.Length - 1).Select(i => weights[i] + weights[i + 1]).OrderBy(x => x).ToArray();
        return Enumerable.Range(0, k - 1).Sum(i => (long)(pairs[^(i + 1)] - pairs[i]));
    }
}