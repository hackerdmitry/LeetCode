using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._3._Hard._857._Minimum_Cost_to_Hire_K_Workers;

public class Solution
{
    public double MincostToHireWorkers(int[] quality, int[] wage, int k)
    {
        var workers = new Worker[quality.Length];
        for (var i = 0; i < quality.Length; i++)
            workers[i] = new Worker(wage[i], quality[i]);

        var minWage = decimal.MaxValue;
        var qualityQueue = new PriorityQueue<int, int>();
        var totalQueue = decimal.Zero;

        foreach (var worker in workers.OrderBy(x => x.Value))
        {
            totalQueue += worker.Quality;
            qualityQueue.Enqueue(worker.Quality, -worker.Quality);

            if (qualityQueue.Count > k)
                totalQueue -= qualityQueue.Dequeue();

            if (qualityQueue.Count == k)
                minWage = Math.Min(minWage, totalQueue * worker.Value);
        }

        return (double) minWage;
    }

    class Worker
    {
        public int Wage { get; set; }
        public int Quality { get; set; }

        public decimal Value { get; set; }

        public Worker(int wage, int quality)
        {
            Wage = wage;
            Quality = quality;
            Value = decimal.Divide(wage, quality);
        }

        public override string ToString()
        {
            return $"q={Quality}, w={Wage}, v={Value:0.00000}";
        }
    }
}