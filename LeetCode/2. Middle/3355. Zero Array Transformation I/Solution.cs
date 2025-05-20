namespace LeetCode._2._Middle._3355._Zero_Array_Transformation_I;

public class Solution
{
    public bool IsZeroArray(int[] nums, int[][] queries)
    {
        var decArr = CreateDecrementArray(nums.Length, queries);
        return CanBeZeroArrayByDecrementArray(nums, decArr);
    }

    private int[] CreateDecrementArray(int length, int[][] queries)
    {
        var decArr = new int[length];
        foreach (var query in queries)
        {
            decArr[query[0]]++;
            if (query[1] + 1 != length)
                decArr[query[1] + 1]--;
        }

        return decArr;
    }

    private bool CanBeZeroArrayByDecrementArray(int[] nums, int[] decArr)
    {
        var current = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            current += decArr[i];
            if (nums[i] > current)
                return false;
        }

        return true;
    }
}
