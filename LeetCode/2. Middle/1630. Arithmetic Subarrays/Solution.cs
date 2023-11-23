using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._1630._Arithmetic_Subarrays;

public class Solution
{
    public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r)
    {
        var result = new bool[l.Length];

        for (var i = 0; i < l.Length; i++)
        {
            var ll = l[i];
            var rr = r[i];

            var subsequence = Enumerable.Range(ll, rr - ll + 1).Select(j => nums[j]).OrderBy(x => x);
            var diff = -1;
            var prevNum = -1;
            var j = 0;
            result[i] = true;
            foreach (var num in subsequence)
            {
                if (j != 0)
                    if (j == 1)
                        diff = num - prevNum;
                    else if (num - prevNum != diff)
                    {
                        result[i] = false;
                        break;
                    }

                prevNum = num;
                j++;
            }
        }

        return result;
    }
}
