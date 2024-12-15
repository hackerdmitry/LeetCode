using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._1792._Maximum_Average_Pass_Ratio;

public class Solution
{
    public double MaxAverageRatio(int[][] rawClasses, int extraStudents)
    {
        var classes = rawClasses.Select(x => new Class(x[0], x[1])).ToArray();

        var priorityQueue = new PriorityQueue<Class, double>(classes.Where(x => x.Boost > 0).Select(x => (x, -x.Boost)));
        if (priorityQueue.Count > 0)
            while (extraStudents-- > 0)
            {
                var currentClass = priorityQueue.Dequeue();
                currentClass.AddExtraStudent();
                priorityQueue.Enqueue(currentClass, -currentClass.Boost);
            }

        return classes.Sum(x => (double)x.Pass / x.Total) / classes.Length;
    }

    private class Class
    {
        public int Pass { get; set; }
        public int Total { get; set; }
        public double Boost { get; set; }

        public Class(int pass, int total)
        {
            Pass = pass;
            Total = total;
            Boost = CalculateBoost();
        }

        public void AddExtraStudent()
        {
            Pass++;
            Total++;
            Boost = CalculateBoost();
        }

        private double CalculateBoost() =>
            (Pass + 1d) / (Total + 1d) - (double)Pass / Total;
    }
}