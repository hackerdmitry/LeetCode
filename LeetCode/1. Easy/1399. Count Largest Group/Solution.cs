using System.Linq;

namespace LeetCode._1._Easy._1399._Count_Largest_Group;

public class Solution
{
    public int CountLargestGroup(int n)
    {
        return Enumerable
            .Range(1, n)
            .GroupBy(CountDigits)
            .GroupBy(x => x.Count())
            .MaxBy(x => x.Key)
            .Count();
    }

    private int CountDigits(int n)
    {
        var result = 0;
        while (n > 0)
        {
            result += n % 10;
            n /= 10;
        }
        return result;
    }
}
