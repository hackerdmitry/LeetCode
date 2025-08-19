namespace LeetCode._2._Middle._2348._Number_of_Zero_Filled_Subarrays;

public class Solution
{
    public long ZeroFilledSubarray(int[] nums)
    {
        var result = 0L;
        var start = -1;
        for (var i = 0; i < nums.Length; i++)
            if (nums[i] == 0 && start == -1)
                start = i;
            else if (nums[i] != 0 && start != -1)
                result += CountPyramide(ref start, i);

        if (start != -1)
            result += CountPyramide(ref start, nums.Length);

        return result;
    }

    private long CountPyramide(ref int start, int end)
    {
        var count = end - start;
        start = -1;
        return (count + 1L) * count / 2;
    }
}
