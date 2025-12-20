namespace LeetCode._1._Easy._944._Delete_Columns_to_Make_Sorted;

public class Solution
{
    public int MinDeletionSize(string[] strs)
    {
        var result = 0;
        var n = strs[0].Length;
        for (var j = 0; j < n; j++)
            for (var i = 1; i < strs.Length; i++)
                if (strs[i - 1][j] > strs[i][j])
                {
                    result++;
                    break;
                }

        return result;
    }
}