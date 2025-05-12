using System.Collections.Generic;
using System.Linq;

namespace LeetCode._1._Easy._2094._Finding_3_Digit_Even_Numbers;

public class Solution
{
    public int[] FindEvenNumbers(int[] digits)
    {
        var groupedDigits = new int[10];
        foreach (var digit in digits)
            groupedDigits[digit]++;
        return GetEvenNumbers(groupedDigits).ToArray();
    }

    private IEnumerable<int> GetEvenNumbers(int[] groupedDigits)
    {
        for (var first = 1; first < 10; first++)
            if (groupedDigits[first] > 0)
            {
                groupedDigits[first]--;
                for (var second = 0; second < 10; second++)
                    if (groupedDigits[second] > 0)
                    {
                        groupedDigits[second]--;
                        for (var third = 0; third < 10; third += 2)
                            if (groupedDigits[third] > 0)
                                yield return first * 100 + second * 10 + third;
                        groupedDigits[second]++;
                    }

                groupedDigits[first]++;
            }
    }
}