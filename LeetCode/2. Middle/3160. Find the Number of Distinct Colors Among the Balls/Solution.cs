using System.Collections.Generic;

namespace LeetCode._2._Middle._3160._Find_the_Number_of_Distinct_Colors_Among_the_Balls;

public class Solution
{
    public int[] QueryResults(int limit, int[][] queries)
    {
        var ballColors = new Dictionary<int, int>();
        var colorCounts = new Dictionary<int, int>();
        var result = new int[queries.Length];
        var currentCountColors = 0;
        for (var i = 0; i < queries.Length; i++)
        {
            var ball = queries[i][0];
            var color = queries[i][1];
            if (ballColors.TryGetValue(ball, out var prevColor))
            {
                colorCounts[prevColor]--;
                if (colorCounts[prevColor] == 0)
                    currentCountColors--;
            }

            ballColors[ball] = color;
            if (!colorCounts.TryAdd(color, 1))
                colorCounts[color]++;
            if (colorCounts[color] == 1)
                currentCountColors++;

            result[i] = currentCountColors;
        }

        return result;
    }
}
