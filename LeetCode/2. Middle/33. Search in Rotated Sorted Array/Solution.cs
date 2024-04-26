namespace LeetCode._2._Middle._33._Search_in_Rotated_Sorted_Array;

public class Solution
{
    public int Search(int[] nums, int target)
    {
        var shift = FindShift(nums);
        return BinarySearchWithRotatedArray(nums, shift, target);
    }

    public int BinarySearchWithRotatedArray(int[] nums, int shift, int target)
    {
        var n = nums.Length;
        var separation = n - shift;
        var l = 0;
        var r = n;

        int GetNum(int index) =>
            nums[GetIndex(index)];

        int GetIndex(int index) =>
            index >= separation
                ? index - separation
                : index + shift;

        if (GetNum(l) == target)
            return GetIndex(l);
        if (n == 1)
            return -1;
        if (GetNum(r) == target)
            return GetIndex(r);

        while (true)
        {
            var m = (l + r) / 2;
            if (GetNum(m) == target)
                return GetIndex(m);

            if (GetNum(m) < target)
                l = m;
            else
                r = m;

            if (r - l == 1)
                return -1;
        }
    }

    public int FindShift(int[] nums)
    {
        var l = 0;
        var r = nums.Length - 1;
        if (nums[l] < nums[r] || l == r)
            return 0;

        while (true)
        {
            var m = (l + r) / 2;
            if (l == m)
                return r;

            if (nums[m] > nums[l])
                l = m;
            else
                r = m;
        }
    }
}