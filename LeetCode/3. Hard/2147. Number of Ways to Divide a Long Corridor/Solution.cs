using System.Collections.Generic;

namespace LeetCode._3._Hard._2147._Number_of_Ways_to_Divide_a_Long_Corridor;

public class Solution
{
    public int NumberOfWays(string corridor)
    {
        var seatPositions = new List<int>();
        for (var i = 0; i < corridor.Length; i++)
            if (corridor[i] == 'S')
                seatPositions.Add(i);

        if (seatPositions.Count % 2 == 1)
            return 0;
        if (seatPositions.Count == 2)
            return 1;

        var result = 0L;
        for (var i = 2; i < seatPositions.Count; i += 2)
            if (result == 0)
                result = seatPositions[i] - seatPositions[i - 1];
            else
            {
                result *= seatPositions[i] - seatPositions[i - 1];
                result %= 1_000_000_007;
            }

        return (int)result;
    }
}
