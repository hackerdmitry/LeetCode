using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._1353._Maximum_Number_of_Events_That_Can_Be_Attended;

public class Solution
{
    public int MaxEvents(int[][] events)
    {
        using var eventEnumerator = events.OrderBy(x => x[0]).GetEnumerator();
        var current = eventEnumerator.MoveNext() ? eventEnumerator.Current : null;

        var result = 0;
        var day = 1;

        var eventQueue = new PriorityQueue<int[], int>();
        while (current != null || eventQueue.Count > 0)
        {
            while (current != null && current[0] <= day && day <= current[1])
            {
                eventQueue.Enqueue(current, current[1]);
                current = eventEnumerator.MoveNext() ? eventEnumerator.Current : null;
            }

            while (eventQueue.Count > 0)
            {
                var candidate = eventQueue.Dequeue();
                if (candidate[0] <= day && day <= candidate[1])
                {
                    result++;
                    break;
                }
            }

            day++;
        }

        return result;
    }
}