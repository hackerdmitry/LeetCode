using System.Collections.Generic;

namespace LeetCode._1._Easy._1496._Path_Crossing;

public class Solution
{
    public bool IsPathCrossing(string path)
    {
        var lastPoint = (0, 0);
        var hash = new HashSet<(int, int)> { lastPoint };
        foreach (var direction in path)
        {
            var directionPoint = direction switch
            {
                'N' => (1, 0),
                'S' => (-1, 0),
                'W' => (0, -1),
                'E' => (0, 1),
            };
            lastPoint = (lastPoint.Item1 + directionPoint.Item1,
                         lastPoint.Item2 + directionPoint.Item2);
            if (!hash.Add(lastPoint))
                return true;
        }

        return false;
    }
}
