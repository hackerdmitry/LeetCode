namespace LeetCode._2._Middle._34._Find_First_and_Last_Position_of_Element_in_Sorted_Array
{
    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            var result = new[] { -1, -1 };
            if (nums.Length == 0)
                return result;

            var left = 0;
            var right = nums.Length - 1;

            var middle = 0;
            while (left != right)
            {
                middle = (left + right) / 2;
                var current = nums[middle];
                if (current < target)
                    left = middle;
                else
                    right = middle;

                if (right - left == 1)
                {
                    if (nums[left] == target)
                        middle = left;
                    else
                        middle = right;
                    break;
                }
            }

            if (nums[middle] == target)
                result[0] = middle;
            else
                return result;

            left = 0;
            right = nums.Length - 1;
            while (left != right)
            {
                middle = (left + right) / 2;
                var current = nums[middle];
                if (current <= target)
                    left = middle;
                else
                    right = middle;

                if (right - left == 1)
                {
                    if (nums[right] == target)
                        middle = right;
                    else
                        middle = left;
                    break;
                }
            }

            result[1] = middle;
            return result;
        }
    }
}