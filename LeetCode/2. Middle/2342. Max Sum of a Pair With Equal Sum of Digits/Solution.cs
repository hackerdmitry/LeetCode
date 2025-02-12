using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._2342._Max_Sum_of_a_Pair_With_Equal_Sum_of_Digits;

public class Solution
{
    public int MaximumSum(int[] nums)
    {
        var dict = new Dictionary<int, LinkedList<int>>();
        foreach (var num in nums)
        {
            var sumDigits = SumDigits(num);
            if (!dict.TryGetValue(sumDigits, out var sameSumDigit))
                dict[sumDigits] = sameSumDigit = new LinkedList<int>();
            AppendNumber(sameSumDigit, num);
        }

        return dict.Count == nums.Length
            ? -1
            : dict.Values.Where(x => x.Count > 1).Max(x => x.Sum());
    }

    private int SumDigits(int num)
    {
        var sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }

        return sum;
    }

    private void AppendNumber(LinkedList<int> sameSumDigit, int num)
    {
        if (sameSumDigit.Count == 0)
            sameSumDigit.AddFirst(num);
        else if (sameSumDigit.Count == 1)
            if (num > sameSumDigit.First!.Value)
                sameSumDigit.AddFirst(num);
            else
                sameSumDigit.AddLast(num);
        else if (num > sameSumDigit.First!.Value)
            sameSumDigit.AddFirst(num);
        else if (num > sameSumDigit.Last!.Value)
            sameSumDigit.AddAfter(sameSumDigit.First, num);
        if (sameSumDigit.Count > 2)
            sameSumDigit.RemoveLast();
    }
}