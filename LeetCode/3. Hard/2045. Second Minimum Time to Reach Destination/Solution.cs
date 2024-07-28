using System.Collections.Generic;

namespace LeetCode._3._Hard._2045._Second_Minimum_Time_to_Reach_Destination;

public class Solution
{
    public int SecondMinimum(int n, int[][] edges, int time, int change)
    {
        var country = CreateCountry(n, edges);
        FillMinimumValue(country, time, change);
        return country[n].SecondMinimumValue!.Value;
    }

    private Dictionary<int, City> CreateCountry(int n, int[][] edges)
    {
        var country = new Dictionary<int, City>(n);
        for (var i = 1; i <= n; i++)
            country[i] = new City(i);
        country[1].FirstMinimumValue = 0;

        foreach (var edge in edges)
        {
            var from = country[edge[0]];
            var to = country[edge[1]];
            from.Neighbours.Add(to);
            to.Neighbours.Add(from);
        }

        return country;
    }

    private void FillMinimumValue(Dictionary<int, City> country, int time, int change)
    {
        var queue = new Queue<(City, int)>();
        queue.Enqueue((country[1], 0));

        while (queue.Count > 0)
        {
            var (city, spentTime) = queue.Dequeue();
            var timeToEnterToAnotherCity = ExitCity(spentTime, change) + time;

            foreach (var neighbour in city.Neighbours)
                if (neighbour.TryAddMinimumValue(timeToEnterToAnotherCity))
                    queue.Enqueue((neighbour, timeToEnterToAnotherCity));
        }
    }

    private int ExitCity(int currentTime, int change) =>
        currentTime / change % 2 == 0
            ? currentTime
            : (currentTime / change + 1) * change;

    class City
    {
        public int Index { get; set; }
        public List<City> Neighbours { get; set; } = new();

        public int? FirstMinimumValue { get; set; }
        public int? SecondMinimumValue { get; set; }

        public City(int index)
        {
            Index = index;
        }

        public bool TryAddMinimumValue(int minimumValue)
        {
            if (!FirstMinimumValue.HasValue || minimumValue < FirstMinimumValue)
            {
                SecondMinimumValue = FirstMinimumValue;
                FirstMinimumValue = minimumValue;
                return true;
            }

            if ((!SecondMinimumValue.HasValue || minimumValue < SecondMinimumValue) && minimumValue != FirstMinimumValue)
            {
                SecondMinimumValue = minimumValue;
                return true;
            }

            return minimumValue == FirstMinimumValue;
        }
    }
}