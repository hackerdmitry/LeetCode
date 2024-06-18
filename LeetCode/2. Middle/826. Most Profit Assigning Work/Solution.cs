using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._826._Most_Profit_Assigning_Work;

public class Solution
{
    public int MaxProfitAssignment(int[] difficulty, int[] profit, int[] worker)
    {
        var enumerableJobs = Enumerable.Range(0, difficulty.Length)
            .Select(i => new Job(difficulty[i], profit[i]))
            .OrderBy(x => x.Difficulty)
            .ThenByDescending(x => x.Profit)
            .DistinctBy(x => x.Difficulty);

        var jobs = new List<Job>(difficulty.Length);
        var curProfit = int.MinValue;
        foreach (var job in enumerableJobs)
            if (job.Profit > curProfit)
            {
                curProfit = job.Profit;
                jobs.Add(job);
            }

        var result = 0;
        foreach (var difficultyWorker in worker)
            result += FindProfit(jobs, difficultyWorker);
        return result;
    }

    private int FindProfit(IList<Job> jobs, int difficulty)
    {
        var left = 0;
        var right = jobs.Count - 1;

        while (left < right)
        {
            var middle = (left + right) / 2;
            if (jobs[middle].Difficulty > difficulty)
                right = middle;
            else if (middle == left)
                if (jobs[right].Difficulty > difficulty)
                    right--;
                else
                    left++;
            else
                left = middle;
        }

        return jobs[left].Difficulty <= difficulty ? jobs[left].Profit : 0;
    }

    record Job(int Difficulty, int Profit);
}