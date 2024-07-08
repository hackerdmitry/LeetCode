using System.Collections.Generic;

namespace LeetCode._2._Middle._1823._Find_the_Winner_of_the_Circular_Game;

public class Solution
{
    public int FindTheWinner(int n, int k)
    {
        var queue = new Queue<int>();
        for (var i = 1; i <= n; i++)
            queue.Enqueue(i);

        while (queue.Count != 1)
        {
            for (var i = 1; i < k; i++)
                queue.Enqueue(queue.Dequeue());
            queue.Dequeue();
        }

        return queue.Dequeue();
    }
}
