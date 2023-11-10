using System.Collections.Generic;

namespace LeetCode._2._Middle._229._Majority_Element_II
{
    public class Solution
    {
        public IList<int> MajorityElement(int[] nums)
        {
            var result = new List<int>();
            var hashSet = new HashSet<int>();
            var dict = new Dictionary<int, int>();
            var limit = nums.Length / 3;
            foreach (var num in nums)
            {
                if (dict.ContainsKey(num))
                    dict[num]++;
                else
                    dict[num] = 1;

                if (dict[num] > limit && !hashSet.Contains(num))
                {
                    hashSet.Add(num);
                    result.Add(num);
                }
            }

            return result;
        }
    }
}