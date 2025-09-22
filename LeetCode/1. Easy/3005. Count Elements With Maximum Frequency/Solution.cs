using System.Linq;

namespace LeetCode._1._Easy._3005._Count_Elements_With_Maximum_Frequency;

public class Solution
{
    public int MaxFrequencyElements(int[] nums)
    {
        var frequencies = nums.GroupBy(x => x).Select(g => g.Count()).OrderByDescending(x => x);
        var maxFrequency = -1;
        var result = 0;
        foreach (var frequency in frequencies)
        {
            if (maxFrequency == -1)
                maxFrequency = frequency;
            else if (maxFrequency != frequency)
                break;
            result += frequency;
        }

        return result;
    }
}