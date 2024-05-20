namespace LeetCode._1._Easy._1863._Sum_of_All_Subset_XOR_Totals;

public class Solution
{
    public int SubsetXORSum(int[] nums)
    {
        var result = 0;
        var limit = 1 << nums.Length;
        for (var mark = 1; mark < limit; mark++)
        {
            var copyMark = mark;
            var i = nums.Length - 1;
            var xor = 0;
            while (copyMark > 0)
            {
                if (copyMark % 2 == 1)
                    xor ^= nums[i];
                copyMark >>= 1;
                i--;
            }

            result += xor;
        }

        return result;
    }
}
