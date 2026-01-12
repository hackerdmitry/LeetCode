namespace LeetCode._2._Middle._33._Search_in_Rotated_Sorted_Array;

public class Solution
{
    public int Search(int[] nums, int target)
    {
        return BinarySearch(nums, target, 0, nums.Length - 1) ?? -1;
    }

    private int? BinarySearch(int[] nums, int target, int left, int right)
    {
        if (left == right)
            return TargetIndex(nums, left, target);

        if (left + 1 == right)
            return TargetIndex(nums, left, target) ?? TargetIndex(nums, right, target);

        if (nums[left] == target)
            return left;

        if (nums[right] == target)
            return right;

        var middle = (right + left) / 2;

        if (nums[middle] == target)
            return middle;

        return nums[left] < nums[middle]
            ? nums[left] < target && target < nums[middle] ? BinarySearch(nums, target, left, middle - 1) : BinarySearch(nums, target, middle + 1, right)
            : nums[middle] >= target || target >= nums[right] ? BinarySearch(nums, target, left, middle - 1) : BinarySearch(nums, target, middle + 1, right);
    }

    private int? TargetIndex(int[] nums, int index, int target) =>
        nums[index] == target ? index : null;
}