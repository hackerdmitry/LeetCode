using System.Collections.Generic;
using System.Linq;

namespace LeetCode._3._Hard._815._Bus_Routes;

public class Solution
{
    public int NumBusesToDestination(int[][] routes, int source, int target)
    {
        var stations = new Dictionary<int, Node>();

        for (var busNumber = 0; busNumber < routes.Length; busNumber++)
        {
            for (var busStationIndex = 0; busStationIndex < routes[busNumber].Length; busStationIndex++)
            {
                var busStation = routes[busNumber][busStationIndex];

                if (!stations.ContainsKey(busStation))
                    stations[busStation] = new Node(busStation);

                if (busStationIndex > 0)
                {
                    var curStation = stations[routes[busNumber][busStationIndex]];
                    var prevStation = stations[routes[busNumber][busStationIndex - 1]];

                    curStation.AddNeighbour(prevStation, busNumber + 1);
                    prevStation.AddNeighbour(curStation, busNumber + 1);
                }
            }
        }

        if (!stations.ContainsKey(source))
            return -1;
        if (!stations.ContainsKey(target))
            return -1;
        if (source == target)
            return 0;
        if (stations[source].Neighbours.Any(stationSource =>
                stations[target].Neighbours.Any(stationTarget =>
                    stationTarget.Item2 == stationSource.Item2)))
            return 1;

        var visited = new HashSet<int>();

        var queue = new PriorityQueue<(Node, int, int), int>();
        queue.Enqueue((stations[source], -1, 0), 0);

        var waveDict = new Dictionary<int, int>();

        while (queue.Count != 0)
        {
            var (curStation, curBusNumber, countOfBuses) = queue.Dequeue();
            if (curStation.Number == target)
                return countOfBuses;

            visited.Add(curStation.Number);

            foreach (var (neighbour, neighbourBusNumber) in curStation.Neighbours)
            {
                if (visited.Contains(neighbour.Number))
                    continue;

                var sameBusNumber = neighbourBusNumber == curBusNumber;
                var neighbourCountOfBuses = sameBusNumber ? countOfBuses : countOfBuses + 1;
                waveDict.TryAdd(neighbourCountOfBuses, 100_000 * countOfBuses);

                queue.Enqueue(
                    (neighbour, neighbourBusNumber, neighbourCountOfBuses),
                    waveDict[neighbourCountOfBuses]++);
            }
        }

        return -1;
    }

    public class Node
    {
        public readonly List<(Node, int)> Neighbours = new();
        public int Number;

        public Node(int number)
        {
            Number = number;
        }

        public void AddNeighbour(Node node, int busNUmber)
        {
            Neighbours.Add((node, busNUmber));
        }
    }
}
