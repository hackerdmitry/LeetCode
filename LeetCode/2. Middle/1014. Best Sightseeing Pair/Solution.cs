namespace LeetCode._2._Middle._1014._Best_Sightseeing_Pair;

public class Solution
{
    public int MaxScoreSightseeingPair(int[] values)
    {
        var bestPriority = values[0];
        var bestValue = values[0];
        var bestIndex = 0;

        var result = values[0] + values[1] - 1;

        for (var i = 1; i < values.Length; i++)
        {
            var targetResult = values[i] + bestValue - i + bestIndex;
            if (targetResult > result)
                result = targetResult;
            var priority = values[i] + i;
            if (priority > bestPriority)
            {
                bestPriority = priority;
                bestValue = values[i];
                bestIndex = i;
            }
        }

        return result;
    }
}
