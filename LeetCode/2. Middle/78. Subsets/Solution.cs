using System.Collections.Generic;

namespace LeetCode._2._Middle._78._Subsets;

public class Solution
{
    public IList<IList<int>> Subsets(int[] nums)
    {
        var result = new List<IList<int>>();
        var limit = 1 << nums.Length;
        for (var mark = 0; mark < limit; mark++)
        {
            var copyMark = mark;
            var count = 0;
            while (copyMark > 0)
            {
                count += copyMark % 2;
                copyMark >>= 1;
            }

            copyMark = mark;
            var array = new int[count];
            var i = nums.Length - 1;
            var j = array.Length - 1;
            while (copyMark > 0)
            {
                if (copyMark % 2 == 1)
                    array[j--] = nums[i];
                copyMark >>= 1;
                i--;
            }

            result.Add(array);
        }

        return result;
    }
}