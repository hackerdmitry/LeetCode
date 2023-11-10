using System;

namespace LeetCode._3._Hard._2009._Minimum_Number_of_Operations_to_Make_Array_Continuous
{
    public class Solution
    {
        public int MinOperations(int[] nums)
        {
            Array.Sort(nums);

            for (var i = 1; i < nums.Length; i++)
                if (nums[i] == nums[i - 1])
                    nums[i - 1] = int.MaxValue;

            Array.Sort(nums);

            var minPermutations = nums.Length - 1;
            var lastNum = nums[^1];
            for (var i = 0; i < nums.Length; i++)
            {
                var num = nums[i];

                if (lastNum - num < minPermutations)
                    break;

                var minIndex = SearchMinIndex(nums, num + nums.Length - 1);
                var curPermutations = nums.Length - 1 - minIndex + i;
                if (curPermutations < minPermutations)
                    minPermutations = curPermutations;
            }

            return minPermutations;
        }

        private int SearchMinIndex(int[] nums, int minNum)
        {
            var left = 0;
            var right = nums.Length - 1;

            while (left < right)
            {
                if (right - 1 == left)
                    return nums[right] <= minNum ? right : left;

                var middle = (left + right) / 2;
                var curNum = nums[middle];
                if (curNum <= minNum)
                    left = middle;
                else
                    right = middle;
            }

            return right;
        }
    }
}