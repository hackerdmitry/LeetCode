using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._3243._Shortest_Distance_After_Road_Addition_Queries_I;

public class Solution
{
    public int[] ShortestDistanceAfterQueries(int n, int[][] queries)
    {
        var points = new List<int>[n];
        for (var i = 0; i < n - 1; i++)
            points[i] = new List<int>(new[] {i + 1});

        var results = new int[queries.Length];
        var dp = new int[n];
        for (var i = 0; i < queries.Length; i++)
        {
            var from = queries[i][0];
            var to = queries[i][1];
            points[from].Add(to);
            ClearDP(dp);
            results[i] = FindMinDistance(points, 0, dp);
        }

        return results;
    }

    private int FindMinDistance(List<int>[] points, int currentNode, int[] dp)
    {
        if (currentNode == points.Length - 1)
            return 0;

        if (dp[currentNode] != -1)
            return dp[currentNode];

        var minDistance = points.Length;
        if (points[currentNode] != null)
            foreach (var to in points[currentNode])
                minDistance = Math.Min(minDistance, FindMinDistance(points, to, dp) + 1);

        return dp[currentNode] = minDistance;
    }

    private void ClearDP(int[] dp)
    {
        for (var i = 0; i < dp.Length; i++)
            dp[i] = -1;
    }
}