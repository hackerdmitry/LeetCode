using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._2125._Number_of_Laser_Beams_in_a_Bank;

public class Solution
{
    public int NumberOfBeams(string[] bank)
    {
        var signalList = new List<int>();
        foreach (var row in bank)
        {
            var count = row.Count(x => x == '1');
            if (count != 0)
                signalList.Add(count);
        }

        var result = signalList.Count > 1 ? signalList[0] * signalList[1] : 0;
        for (var i = 2; i < signalList.Count; i++)
            result += signalList[i] * signalList[i - 1];

        return result;
    }
}
