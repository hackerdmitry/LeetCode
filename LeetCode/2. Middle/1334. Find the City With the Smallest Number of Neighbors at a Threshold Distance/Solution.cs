using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._1334._Find_the_City_With_the_Smallest_Number_of_Neighbors_at_a_Threshold_Distance;

public class Solution
{
    public int FindTheCity(int n, int[][] edges, int distanceThreshold)
    {
        var country = CreateCountry(n, edges);
        return Enumerable.Range(0, n)
            .Select(i => (x: GetCountReachableCities(country[i], distanceThreshold), i))
            .OrderBy(x => x.x)
            .ThenByDescending(x => x.i)
            .First().i;
    }

    private int GetCountReachableCities(City startPoint, int distanceThreshold)
    {
        var queue = new Queue<(int, City)>();
        var visited = new Dictionary<int, int>();

        queue.Enqueue((distanceThreshold, startPoint));
        visited[startPoint.Index] = distanceThreshold;

        while (queue.Count > 0)
        {
            var (remainDistance, city) = queue.Dequeue();
            foreach (var (weight, neighbourCity) in city.Neighbours)
            {
                var neighbourRemainDistance = remainDistance - weight;
                if (weight <= remainDistance &&
                    (!visited.ContainsKey(neighbourCity.Index) || visited[neighbourCity.Index] < neighbourRemainDistance))
                {
                    visited[neighbourCity.Index] = neighbourRemainDistance;
                    queue.Enqueue((neighbourRemainDistance, neighbourCity));
                }
            }
        }

        return visited.Count;
    }

    private City[] CreateCountry(int n, int[][] edges)
    {
        var country = Enumerable.Range(0, n).Select(x => new City(x)).ToArray();
        foreach (var edge in edges)
        {
            country[edge[0]].Neighbours.Add((edge[2], country[edge[1]]));
            country[edge[1]].Neighbours.Add((edge[2], country[edge[0]]));
        }

        return country;
    }

    class City
    {
        public int Index { get; }
        public List<(int, City)> Neighbours { get; } = new();

        public City(int index)
        {
            Index = index;
        }
    }
}