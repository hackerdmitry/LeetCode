using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;

namespace LeetCode._3._Hard._2463._Minimum_Total_Distance_Traveled;

public class Solution
{
    public long MinimumTotalDistance(IList<int> inputRobots, int[][] inputFactories)
    {
        var robotPositions = inputRobots.OrderBy(x => x).ToArray();
        var factoryPositions = inputFactories.OrderBy(x => x[0]).SelectMany(x => Enumerable.Repeat(x[0], x[1])).ToArray();

        var robotToFactoryDistances = GetRobotToFactoryDistances(robotPositions, factoryPositions);
        return CalculateMinDistance(robotToFactoryDistances);
    }

    private int[,] GetRobotToFactoryDistances(int[] robotPositions, int[] factoryPositions)
    {
        var factoryLineLength = factoryPositions.Length - robotPositions.Length + 1;
        var robotToFactoryDistances = new int[robotPositions.Length, factoryLineLength];

        for (int y = 0; y < robotPositions.Length; y++)
            for (int x = 0; x < factoryLineLength; x++)
                robotToFactoryDistances[y, x] = Math.Abs(robotPositions[y] - factoryPositions[x + y]);

        return robotToFactoryDistances;
    }

    private long CalculateMinDistance(int[,] robotToFactoryDistances)
    {
        var height = robotToFactoryDistances.GetLength(0);
        var width = robotToFactoryDistances.GetLength(1);

        var priorityQueue = new PriorityQueue<RobotToFactoryDistance, long>(width * 3);
        for (var x = 0; x < width; x++)
        {
            var distance = robotToFactoryDistances[0, x];
            priorityQueue.Enqueue(new RobotToFactoryDistance(0, x, distance), GetPriority(distance));
        }

        while (priorityQueue.Count > 0)
        {
            var robotToFactoryDistance = priorityQueue.Dequeue();
            if (robotToFactoryDistance.Y == height - 1)
                return robotToFactoryDistance.Distance;

            var nextY = robotToFactoryDistance.Y + 1;
            for (var x = robotToFactoryDistance.X; x < width; x++)
            {
                var distance = robotToFactoryDistance.Distance + robotToFactoryDistances[nextY, x];
                priorityQueue.Enqueue(new RobotToFactoryDistance(nextY, x, distance), GetPriority(distance));
            }
        }

        return long.MaxValue;
    }

    private long GetPriority(long minDistance) => minDistance;

    private class RobotToFactoryDistance
    {
        public int Y { get; set; }
        public int X { get; set; }
        public long Distance { get; set; }

        public RobotToFactoryDistance(int y, int x, long distance)
        {
            Y = y;
            X = x;
            Distance = distance;
        }
    }
}