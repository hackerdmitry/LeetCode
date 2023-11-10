using System;
using System.Linq;

namespace LeetCode._1._Two_Sum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var numPositions = nums
                .Select((x, i) => (x, i))
                .GroupBy(x => x.x, x => x.i)
                .ToDictionary(x => x.Key, x => x.ToArray());
            foreach (var numPosition in numPositions)
            {
                if (target % 2 == 0 &&
                    target / 2 == numPosition.Key)
                {
                    if (numPosition.Value.Length == 2)
                        return numPosition.Value;
                }
                else if (numPositions.ContainsKey(target - numPosition.Key))
                    return new[] {numPosition.Value.First(), numPositions[target - numPosition.Key].First()};
            }

            throw new NotImplementedException();
        }
    }
}