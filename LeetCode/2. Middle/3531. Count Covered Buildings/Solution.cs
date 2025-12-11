using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._3531._Count_Covered_Buildings;

public class Solution
{
    public int CountCoveredBuildings(int n, int[][] buildings)
    {
        var buildingsByY = new Dictionary<int, Bag>();
        var buildingsByX = new Dictionary<int, Bag>();
        foreach (var building in buildings)
        {
            AddToBuildings(buildingsByY, building[1], building[0]);
            AddToBuildings(buildingsByX, building[0], building[1]);
        }

        var result = 0;
        foreach (var (y, bag) in buildingsByY)
            foreach (var x in bag.GetBetweenValues())
                if (buildingsByX[x].ContainsBetweenValue(y))
                    result++;
        return result;
    }

    private void AddToBuildings(Dictionary<int, Bag> buildings, int key, int value)
    {
        if (!buildings.TryGetValue(key, out var bag))
            buildings.Add(key, bag = new Bag());
        bag.Add(value);
    }

    private class Bag
    {
        private int Max { get; set; } = int.MinValue;
        private int Min { get; set; } = int.MaxValue;
        private HashSet<int> Values { get; } = new();

        public void Add(int value)
        {
            Max = Math.Max(Max, value);
            Min = Math.Min(Min, value);
            Values.Add(value);
        }

        public bool ContainsBetweenValue(int value)
        {
            return Values.Contains(value) && value != Min && value != Max;
        }

        public IEnumerable<int> GetBetweenValues()
        {
            foreach (var value in Values)
                if (value != Min && value != Max)
                    yield return value;
        }
    }
}