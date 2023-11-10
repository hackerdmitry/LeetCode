using System;
using System.Collections.Generic;

namespace LeetCode._3._Hard._1269._Number_of_Ways_to_Stay_in_the_Same_Place_After_Some_Steps
{
    public class Solution
    {
        const int module = 1_000_000_007;

        public int NumWays(int steps, int arrLen)
        {
            var ways = new List<int[]> {new int[steps + 1]};
            ways[0][0] = 1;

            for (int i = 0; i < steps; i++)
            {
                var maxJ = Math.Min(i + 2, arrLen);
                if (ways.Count < maxJ)
                    ways.Add(new int[steps + 1]);

                for (int j = 0; j < maxJ; j++)
                {
                    var result = ways[j][i];
                    if (j != 0)
                        result = (result + ways[j - 1][i]) % module;
                    if (j != maxJ - 1)
                        result = (result + ways[j + 1][i]) % module;
                    ways[j][i + 1] = result;
                }
            }

            return ways[0][steps];
        }
    }
}