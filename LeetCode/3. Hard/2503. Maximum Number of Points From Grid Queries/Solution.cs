using System.Collections.Generic;
using System.Linq;

namespace LeetCode._3._Hard._2503._Maximum_Number_of_Points_From_Grid_Queries;

public class Solution
{
    private readonly int[] directions = {-1, 0, 1, 0, -1};

    public int[] MaxPoints(int[][] grid, int[] queries)
    {
        var filledPoints = 0;
        var m = grid.Length;
        var n = grid[0].Length;
        var touched = new bool[m][];
        for (var i = 0; i < m; i++)
            touched[i] = new bool[n];

        var query = new PriorityQueue<(int, int), int>();
        query.Enqueue((0, 0), grid[0][0]);
        touched[0][0] = true;

        var orderedQueries = queries.OrderBy(x => x).Distinct().ToArray();
        var orderedQueriesIndex = 0;
        var answers = new Dictionary<int, int>();

        while (orderedQueriesIndex < orderedQueries.Length && query.Count > 0)
        {
            var (y, x) = query.Peek();
            var value = grid[y][x];
            if (value < orderedQueries[orderedQueriesIndex])
            {
                filledPoints++;
                query.Dequeue();
                for (var i = 0; i < 4; i++)
                {
                    var ny = directions[i] + y;
                    var nx = directions[i + 1] + x;
                    if (ny >= 0 && nx >= 0 && ny < m && nx < n && !touched[ny][nx])
                    {
                        touched[ny][nx] = true;
                        query.Enqueue((ny, nx), grid[ny][nx]);
                    }
                }
            }
            else
            {
                answers[orderedQueries[orderedQueriesIndex]] = filledPoints;
                orderedQueriesIndex++;
            }
        }

        for (; orderedQueriesIndex < orderedQueries.Length; orderedQueriesIndex++)
            answers[orderedQueries[orderedQueriesIndex]] = filledPoints;

        for (var i = 0; i < queries.Length; i++)
            queries[i] = answers[queries[i]];
        return queries;
    }
}