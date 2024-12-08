using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._2054._Two_Best_Non_Overlapping_Events;

public class Solution
{
    public int MaxTwoEvents(int[][] events)
    {
        return MaxTwoEvents(events.Select(x => new Event(x[0], x[1], x[2])));
    }

    private int MaxTwoEvents(IEnumerable<Event> events)
    {
        var priorityQueue = new PriorityQueue<Event, int>();
        using var orderedEventsEnumerator = events.OrderBy(x => x.Start).GetEnumerator();
        orderedEventsEnumerator.MoveNext();
        var maxSum = orderedEventsEnumerator.Current!.Value;
        var currentEvent = orderedEventsEnumerator.Current;
        var maxValueEvent = new Event(0, 0, 0);
        priorityQueue.Enqueue(currentEvent, currentEvent.End);

        while (orderedEventsEnumerator.MoveNext())
        {
            currentEvent = orderedEventsEnumerator.Current;

            while (priorityQueue.Count > 0)
            {
                var earlyEvent = priorityQueue.Peek();
                if (earlyEvent.End >= currentEvent.Start)
                    break;
                if (earlyEvent.Value > maxValueEvent.Value)
                    maxValueEvent = earlyEvent;
                priorityQueue.Dequeue();
            }

            maxSum = Math.Max(maxSum, maxValueEvent.Value + currentEvent.Value);
            priorityQueue.Enqueue(currentEvent, currentEvent.End);
        }

        return maxSum;
    }

    private class Event
    {
        public int Start { get; }
        public int End { get; }
        public int Value { get; }

        public Event(int start, int end, int value)
        {
            Start = start;
            End = end;
            Value = value;
        }
    }
}