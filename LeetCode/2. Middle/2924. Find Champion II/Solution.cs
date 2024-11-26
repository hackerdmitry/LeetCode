using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._2924._Find_Champion_II;

public class Solution
{
    public int FindChampion(int n, int[][] edges)
    {
        var teams = new Dictionary<int, Team>();

        for (var i = 0; i < n; i++)
            teams.Add(i, new Team());

        foreach (var edge in edges)
        {
            var team1 = teams[edge[0]];
            var team2 = teams[edge[1]];

            team2.WeakerThan.Add(team1);
        }

        var strongestTeams = teams.Where(x => x.Value.WeakerThan.Count == 0).Select(x => x.Key).GetEnumerator();
        if (!strongestTeams.MoveNext())
            return -1;

        var strongestTeam = strongestTeams.Current;
        return !strongestTeams.MoveNext()
            ? strongestTeam
            : -1;
    }

    private class Team
    {
        public List<Team> WeakerThan { get; } = new();
    }
}