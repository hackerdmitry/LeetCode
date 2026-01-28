using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._3._Hard._3651._Minimum_Cost_Path_with_Teleportations;

public class Solution
{
    public int MinCost(int[][] grid, int k)
    {
        var m = grid.Length;
        var n = grid[0].Length;

        var minResult = int.MaxValue;
        var orderedGrid = CreateOrderedGrid(m, n, grid);

        var dp = new int[k + 1][][];
        var prevProfits = (ProfitDictionary) null;
        for (var i = 0; i <= k; i++)
        {
            dp[i] = CreateDP(m, n, grid, prevProfits);
            minResult = Math.Min(minResult, dp[i][m - 1][n - 1]);
            prevProfits = CreateProfitDictionary(dp[i], orderedGrid);
        }

        return minResult;
    }

    private int[][] CreateDP(int m, int n, int[][] grid, ProfitDictionary prevProfits)
    {
        var dp = CreateGrid(m, n);
        dp[0][0] = 0;

        for (var x = 1; x < n; x++)
        {
            var cost = dp[0][x - 1] + grid[0][x];
            if (prevProfits != null)
            {
                var minCost = prevProfits.FindMinCost(grid[0][x]);
                if (minCost != -1)
                    cost = Math.Min(cost, minCost);
            }

            dp[0][x] = cost;
        }

        for (var y = 1; y < m; y++)
        {
            var cost = dp[y - 1][0] + grid[y][0];
            if (prevProfits != null)
            {
                var minCost = prevProfits.FindMinCost(grid[y][0]);
                if (minCost != -1)
                    cost = Math.Min(cost, minCost);
            }

            dp[y][0] = cost;
        }

        for (var y = 1; y < m; y++)
            for (var x = 1; x < n; x++)
            {
                var cost = Math.Min(dp[y - 1][x], dp[y][x - 1]) + grid[y][x];
                if (prevProfits != null)
                {
                    var minCost = prevProfits.FindMinCost(grid[y][x]);
                    if (minCost != -1)
                        cost = Math.Min(cost, minCost);
                }

                dp[y][x] = cost;
            }

        return dp;
    }

    private int[][] CreateGrid(int m, int n)
    {
        var grid = new int[m][];
        for (var i = 0; i < grid.Length; i++)
        {
            grid[i] = new int[n];
            for (var j = 0; j < grid[i].Length; j++)
                grid[i][j] = -1;
        }

        return grid;
    }

    private bool InBound(int y, int x, int m, int n)
    {
        return y >= 0 && y < m && x >= 0 && x < n;
    }

    private (int Y, int X, int Value)[] CreateOrderedGrid(int m, int n, int[][] grid)
    {
        var firstCell = grid[0][0];
        var countLowerCells = grid.SelectMany(x => x).Count(x => x < firstCell);

        var cells = new (int Y, int X, int Value)[m * n - countLowerCells];
        var index = 0;
        for (var i = 0; i < m; i++)
            for (var j = 0; j < n; j++)
                if (grid[i][j] >= firstCell)
                    cells[index++] = (i, j, grid[i][j]);

        Array.Sort(cells, (a, b) => a.Value.CompareTo(b.Value));
        return cells;
    }

    private ProfitDictionary CreateProfitDictionary(int[][] dp, (int Y, int X, int Value)[] orderedGrid)
    {
        var linkedList = new LinkedList<(int Value, int Cost)>();
        linkedList.AddLast((orderedGrid[0].Value, 0));
        foreach (var (y, x, value) in orderedGrid.Skip(1))
        {
            var cost = dp[y][x];
            while (linkedList.Count > 1 && cost <= linkedList.Last.Value.Cost)
                linkedList.RemoveLast();
            if (value != linkedList.Last.Value.Value)
                linkedList.AddLast((value, cost));
        }

        var profitDict = new ProfitDictionary();
        foreach (var (value, cost) in linkedList)
            profitDict.AddMinCost(value, cost);

        return profitDict;
    }

    private class ProfitDictionary
    {
        private readonly List<int> indexToKeys = new();
        private readonly Dictionary<int, int> valueToCost = new();

        public int FindMinCost(int value)
        {
            if (indexToKeys.Count == 0 || indexToKeys[^1] < value)
                return -1;

            var maxIndex = BinarySearchMin(0, indexToKeys.Count - 1, index => value <= indexToKeys[index]);
            return valueToCost[indexToKeys[maxIndex]];
        }

        public void AddMinCost(int value, int cost)
        {
            indexToKeys.Add(value);
            valueToCost[value] = cost;
        }
    }

    private static int BinarySearchMin(int left, int right, Func<int, bool> canBeRight)
    {
        while (left < right)
        {
            var mid = (left + right) / 2;
            var isRight = canBeRight(mid);
            if (isRight)
                right = mid;
            else if (left == mid)
                left++;
            else
                left = mid;
        }

        return left;
    }
}