using System.Linq;

namespace LeetCode._823._Binary_Trees_With_Factors
{
    public class Solution
    {
        private const int modulo = 1_000_000_007;

        public int NumFactoredBinaryTrees(int[] arr)
        {
            var sum = Enumerable.Range(0, arr.Length).Select(_ => 1L).ToArray();
            arr = arr.OrderBy(x => x).ToArray();
            var dict = arr.Select((x, i) => (x, i)).ToDictionary(x => x.x, x => x.i);

            for (var i = 1; i < arr.Length; i++)
            {
                for (var j = 0; j < i; j++)
                {
                    if (arr[i] % arr[j] == 0 && dict.ContainsKey(arr[i] / arr[j]))
                    {
                        var left = sum[j];
                        var right = sum[dict[arr[i] / arr[j]]];
                        sum[i] = (sum[i] + left * right) % modulo;
                    }
                }
            }

            return (int)(sum.Sum() % modulo);
        }
    }
}