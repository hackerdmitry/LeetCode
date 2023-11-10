using System.Collections.Generic;

namespace LeetCode._2._Middle._1441._Build_an_Array_With_Stack_Operations;

public class Solution
{
    public IList<string> BuildArray(int[] target, int n)
    {
        var result = new List<string>();

        var targetIndex = 0;
        for (var i = 1; i <= n && targetIndex < target.Length; i++)
        {
            result.Add("Push");
            if (i == target[targetIndex])
                targetIndex++;
            else
                result.Add("Pop");
        }

        return result;
    }
}
