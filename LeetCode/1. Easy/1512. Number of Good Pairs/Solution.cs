using System.Collections.Generic;

namespace LeetCode._1._Easy._1512._Number_of_Good_Pairs
{
    public class Solution
    {
        public int NumIdenticalPairs(int[] nums)
        {
            var dict = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (dict.ContainsKey(num))
                    dict[num]++;
                else
                    dict[num] = 1;
            }

            var sum = 0;
            foreach (var (_, value) in dict)
            {
                if (value > 1)
                    sum += value * (value - 1) / 2;
            }

            return sum;
        }
    }
}