using System.Collections.Generic;

namespace LeetCode._2._Middle._1466._Reorder_Routes_to_Make_All_Paths_Lead_to_the_City_Zero;

public class Solution
{
    public int MinReorder(int n, int[][] connections)
    {
        var nodes = new LinkedList<(int, bool)>[n];
        var visited = new int[n];
        for (var i = 0; i < n; i++)
        {
            nodes[i] = new();
            visited[i] = -1;
        }

        foreach (var connection in connections)
        {
            nodes[connection[0]].AddLast((connection[1], true));
            nodes[connection[1]].AddLast((connection[0], false));
        }

        var queue = new Queue<(int, int)>();
        queue.Enqueue((0, 0));
        visited[0] = 0;

        var result = 0;
        while (queue.Count > 0)
        {
            var (node, reverses) = queue.Dequeue();
            foreach (var (neighbour, isTo) in nodes[node])
            {
                var neighbourReverses = isTo ? reverses + 1 : reverses;
                if (visited[neighbour] == -1 || neighbourReverses < visited[neighbour])
                {
                    result += neighbourReverses - (visited[neighbour] == -1 ? reverses : visited[neighbour]);
                    visited[neighbour] = neighbourReverses;
                    queue.Enqueue((neighbour, neighbourReverses));
                }
            }
        }

        return result;
    }
}