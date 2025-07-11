using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._3._Hard._2402._Meeting_Rooms_III;

public class Solution
{
    public int MostBooked(int n, int[][] rawMeetings)
    {
        var rooms = Enumerable.Range(0, n).Select(i => new Room {Id = i}).ToArray();
        var meetings = rawMeetings.Select(x => new Meeting {StartFrom = x[0], Duration = x[1] - x[0]}).ToArray();

        var busyRoomsQueue = new PriorityQueue<Room, long>();
        var availableRoomsQueue = new PriorityQueue<Room, int>(rooms.Select(r => (r, r.Id)));

        foreach (var meeting in meetings.OrderBy(m => m.StartFrom))
        {
            var room = GetRoom(meeting.StartFrom, busyRoomsQueue, availableRoomsQueue);
            // var room = rooms.Where(x => x.BusyTo <= meeting.StartFrom).OrderBy(x => x.Id).FirstOrDefault() ??
            //            rooms.OrderBy(x => x.BusyTo).ThenBy(x => x.Id).First();
            room.BusyTo = Math.Max(meeting.StartFrom, room.BusyTo) + meeting.Duration;
            room.HeldRoomsCount++;

            busyRoomsQueue.Enqueue(room, room.Priority);
        }

        return rooms.MaxBy(x => x.HeldRoomsCount).Id;
    }

    private Room GetRoom(long time, PriorityQueue<Room, long> busyRoomsQueue, PriorityQueue<Room, int> availableRoomsQueue)
    {
        while (busyRoomsQueue.Count > 0 && busyRoomsQueue.Peek().BusyTo <= time)
        {
            var room = busyRoomsQueue.Dequeue();
            availableRoomsQueue.Enqueue(room, room.Id);
        }

        return availableRoomsQueue.Count > 0
            ? availableRoomsQueue.Dequeue()
            : busyRoomsQueue.Dequeue();
    }

    private class Meeting
    {
        public int StartFrom { get; set; }
        public int Duration { get; set; }
    }

    private class Room
    {
        public int Id { get; set; }
        public int HeldRoomsCount { get; set; }
        public long BusyTo { get; set; }

        public long Priority => BusyTo * 100 + Id;
    }
}
