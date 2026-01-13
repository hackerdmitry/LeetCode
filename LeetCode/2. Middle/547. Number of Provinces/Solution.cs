using System.Collections.Generic;

namespace LeetCode._2._Middle._547._Number_of_Provinces;

public class Solution
{
    public int FindCircleNum(int[][] isConnected)
    {
        var result = 0;
        var queue = new Queue<int>();
        var visited = new HashSet<int>();

        for (var i = 0; i < isConnected.Length; i++)
            if (visited.Add(i))
            {
                result++;
                queue.Enqueue(i);

                while (queue.Count > 0)
                {
                    var node = queue.Dequeue();
                    for (var j = 0; j < isConnected.Length; j++)
                        if (isConnected[node][j] == 1 && visited.Add(j))
                            queue.Enqueue(j);
                }
            }

        return result;
    }
}