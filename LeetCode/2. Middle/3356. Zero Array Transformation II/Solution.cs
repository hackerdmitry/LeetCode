namespace LeetCode._2._Middle._3356._Zero_Array_Transformation_II;

public class Solution
{
    public int MinZeroArray(int[] nums, int[][] queries)
    {
        var diffArray = new int[nums.Length];
        var k = -1;
        for (var i = 0; i < nums.Length && k < queries.Length; i++)
        {
            if (i > 0)
                diffArray[i] += diffArray[i - 1];

            var num = nums[i];
            while (num > diffArray[i] && ++k < queries.Length)
                if (queries[k][1] >= i)
                {
                    if (queries[k][0] <= i && i <= queries[k][1])
                        diffArray[i] += queries[k][2];
                    else
                        diffArray[queries[k][0]] += queries[k][2];
                    if (queries[k][1] + 1 < diffArray.Length)
                        diffArray[queries[k][1] + 1] -= queries[k][2];
                }
        }

        return k == queries.Length ? -1 : k + 1;
    }
}