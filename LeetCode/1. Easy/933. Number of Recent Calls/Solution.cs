using System.Collections.Generic;

namespace LeetCode._1._Easy._933._Number_of_Recent_Calls;

public class RecentCounter
{
    private readonly Queue<int> queue = new();

    public RecentCounter() { }

    public int Ping(int t)
    {
        while (queue.Count > 0 && queue.Peek() + 3000 < t)
            queue.Dequeue();
        queue.Enqueue(t);
        return queue.Count;
    }
}