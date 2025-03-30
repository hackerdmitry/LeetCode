using System;

namespace LeetCode._2._Middle._1395._Count_Number_of_Teams;

public class Solution
{
    public int NumTeams(int[] rating)
    {
        var increasingCache = new TeamCache(rating.Length);
        var decreasingCache = new TeamCache(rating.Length);
        var teamsValue = 0;
        for (var i = 0; i < rating.Length; i++)
            teamsValue += CountTeams(rating, i, 1, increasingCache, (prev, curr) => prev < curr) +
                          CountTeams(rating, i, 1, decreasingCache, (prev, curr) => prev > curr);
        return teamsValue;
    }

    private int CountTeams(int[] rating, int currentIndex, int teamSize, TeamCache cache, Func<int, int, bool> compare)
    {
        if (cache.GetCacheValue(currentIndex, teamSize) != 0)
            return cache.GetCacheValue(currentIndex, teamSize);

        if (teamSize == 3)
            return 1;

        var teamsValue = 0;
        for (var nextIndex = currentIndex + 1; nextIndex < rating.Length; nextIndex++)
            if (compare(rating[currentIndex], rating[nextIndex]))
                teamsValue += CountTeams(rating, nextIndex, teamSize + 1, cache, compare);
        cache.SetCacheValue(currentIndex, teamSize, teamsValue);
        return teamsValue;
    }

    private class TeamCache
    {
        private readonly int[,] cache;

        public TeamCache(int ratingSize) =>
            cache = new int[ratingSize, 3];

        public int GetCacheValue(int index, int teamSize) =>
            cache[index, teamSize - 1];

        public void SetCacheValue(int index, int teamSize, int value) =>
            cache[index, teamSize - 1] = value;
    }
}
