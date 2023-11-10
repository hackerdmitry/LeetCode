namespace LeetCode._896._Monotonic_Array
{
    public class Solution
    {
        public bool IsMonotonic(int[] nums)
        {
            var isIncrease = (bool?) null;
            for (var i = 1; i < nums.Length; i++)
            {
                var cur = nums[i];
                var prev = nums[i - 1];
                if (cur != prev)
                {
                    if (isIncrease.HasValue)
                    {
                        if (prev > cur ^ !isIncrease.Value)
                            return false;
                    }
                    else isIncrease = prev < cur;
                }
            }

            return true;
        }
    }
}