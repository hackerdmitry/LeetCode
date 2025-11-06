using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._3607._Power_Grid_Maintenance;

public class Solution
{
    public int[] ProcessQueries(int c, int[][] connections, int[][] queries)
    {
        var namedGrid = CreateNamedGrid(c, connections);
        var isOffline = new bool[c];

        var countNamedGrids = namedGrid.Max();
        var priorityQueues = new PriorityQueue<int, int>[countNamedGrids];
        for (var i = 0; i < countNamedGrids; i++)
            priorityQueues[i] = new PriorityQueue<int, int>();

        for (var i = 0; i < namedGrid.Length; i++)
            priorityQueues[namedGrid[i] - 1].Enqueue(i, i);

        var result = new int[queries.Count(x => x[0] == 1)];
        var resultIndex = 0;

        foreach (var query in queries)
        {
            var node = query[1] - 1;
            switch (query[0])
            {
                case 1:
                    if (isOffline[node])
                    {
                        var gridPriorityQueue = priorityQueues[namedGrid[node] - 1];
                        while (isOffline[node] && gridPriorityQueue.Count > 0)
                            node = gridPriorityQueue.Dequeue();
                        if (isOffline[node] && gridPriorityQueue.Count == 0)
                            node = -2;
                        else
                            gridPriorityQueue.Enqueue(node, node);
                    }

                    result[resultIndex++] = node + 1;
                    break;
                case 2:
                    isOffline[node] = true;
                    break;
            }
        }

        return result;
    }

    private int[] CreateNamedGrid(int c, int[][] connections)
    {
        var namedGrid = new int[c];

        var neighbours = new LinkedList<int>[c];
        foreach (var connection in connections)
        {
            AddNeighbour(connection[0], connection[1]);
            AddNeighbour(connection[1], connection[0]);
        }

        void AddNeighbour(int from, int to)
        {
            if (neighbours[from - 1] == null)
                neighbours[from - 1] = new LinkedList<int>();
            neighbours[from - 1].AddLast(to - 1);
        }

        var currNameGrid = 1;
        var bfs = new Queue<int>();
        for (var i = 0; i < c; i++)
            if (namedGrid[i] == 0)
            {
                bfs.Enqueue(i);
                while (bfs.Count > 0)
                {
                    var node = bfs.Dequeue();
                    namedGrid[node] = currNameGrid;
                    if (neighbours[node] != null)
                        foreach (var neighbourNode in neighbours[node])
                            if (namedGrid[neighbourNode] == 0)
                                bfs.Enqueue(neighbourNode);
                }

                currNameGrid++;
            }

        return namedGrid;
    }
}