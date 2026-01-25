using System.Collections.Generic;

namespace LeetCode._1._Easy._228._Summary_Ranges;

public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        var result = new List<string>();
        if (nums.Length == 0)
            return result;

        var start = 0;
        for (var end = 1; end < nums.Length; end++)
            if (nums[end - 1] + 1 != nums[end])
            {
                result.Add(FormatRange(nums, start, end - 1));
                start = end;
            }

        result.Add(FormatRange(nums, start, nums.Length - 1));
        return result;
    }

    private string FormatRange(int[] nums, int start, int end)
    {
        return start == end ? nums[start].ToString() : $"{nums[start]}->{nums[end]}";
    }
}
