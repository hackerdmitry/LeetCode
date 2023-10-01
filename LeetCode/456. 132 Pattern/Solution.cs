using System.Collections.Generic;

namespace LeetCode._456._132_Pattern
{
    public class Solution
    {
        public bool Find132pattern(int[] nums)
        {
            var min = nums[0];
            var periods = new LinkedList<(int, int?)>();
            periods.AddFirst((min, null));

            for (var i = 1; i < nums.Length; i++)
            {
                var num = nums[i];

                if (num < min)
                {
                    min = num;
                    if (periods.Last!.Value.Item2.HasValue)
                        periods.AddLast((min, null));
                    else
                        periods.Last.Value = (min, null);
                }
                else
                {
                    var period = periods.First;
                    while (period != null)
                    {
                        if (!period.Value.Item2.HasValue && num > period.Value.Item1 ||
                            num > period.Value.Item2)
                        {
                            period.Value = (period.Value.Item1, num);
                            if (period.Previous != null &&
                                period.Value.Item1 <= period.Previous.Value.Item1 &&
                                period.Value.Item2 >= period.Previous.Value.Item2)
                                periods.Remove(period.Previous);
                        }
                        if (period.Value.Item1 < num && num < period.Value.Item2)
                            return true;

                        period = period.Next;
                    }
                }
            }

            return false;
        }
    }
}