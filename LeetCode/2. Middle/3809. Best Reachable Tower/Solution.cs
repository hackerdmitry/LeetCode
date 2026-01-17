using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._3809._Best_Reachable_Tower;

public class Solution
{
    public int[] BestTower(int[][] towers, int[] center, int radius)
    {
        var reachableTowers = GetReachableTowers(towers, center, radius);
        return GetBestTower(reachableTowers);
    }

    private IEnumerable<int[]> GetReachableTowers(int[][] towers, int[] center, int radius)
    {
        return towers.Where(tower =>
        {
            var dx = Math.Abs(tower[0] - center[0]);
            var dy = Math.Abs(tower[1] - center[1]);
            return dx + dy <= radius;
        });
    }

    private int[] GetBestTower(IEnumerable<int[]> reachableTowers)
    {
        var bestTower = reachableTowers
            .OrderByDescending(tower => tower[2])
            .ThenBy(tower => tower[0])
            .ThenBy(tower => tower[1])
            .FirstOrDefault();
        return bestTower == null
            ? new[] {-1, -1}
            : new[] {bestTower[0], bestTower[1]};
    }
}