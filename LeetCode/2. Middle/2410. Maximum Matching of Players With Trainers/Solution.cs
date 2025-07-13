using System;

namespace LeetCode._2._Middle._2410._Maximum_Matching_of_Players_With_Trainers;

public class Solution
{
    public int MatchPlayersAndTrainers(int[] players, int[] trainers)
    {
        Array.Sort(players);
        Array.Sort(trainers);

        var trainerMatchIndex = 0;
        for (var playerIndex = 0; playerIndex < players.Length; playerIndex++)
        {
            while (trainerMatchIndex < trainers.Length && trainers[trainerMatchIndex] < players[playerIndex])
                trainerMatchIndex++;
            if (trainerMatchIndex == trainers.Length)
                return playerIndex;
            trainerMatchIndex++;
        }

        return players.Length;
    }
}