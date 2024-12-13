using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._2593._Find_Score_of_an_Array_After_Marking_All_Elements;

public class Solution
{
    public long FindScore(int[] nums)
    {
        var marked = new HashSet<(int, int)>(nums.Length);

        var score = 0L;
        foreach (var value in nums.Select((x,i)=>(x,i)).OrderBy(x => x.x).ThenBy(x => x.i))
            if (!marked.Contains(value))
            {
                score += value.x;
                marked.Add(value);
                if (value.i > 0)
                    marked.Add((nums[value.i - 1], value.i - 1));
                if (value.i + 1 < nums.Length)
                    marked.Add((nums[value.i + 1], value.i + 1));
            }

        return score;
    }
}
