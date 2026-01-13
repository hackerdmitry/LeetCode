using System.Collections.Generic;

namespace LeetCode._2._Middle._841._Keys_and_Rooms;

public class Solution
{
    public bool CanVisitAllRooms(IList<IList<int>> rooms)
    {
        var queue = new Queue<int>();
        var visited = new HashSet<int> { 0 };
        queue.Enqueue(0);

        while (queue.Count > 0)
        {
            var room = queue.Dequeue();
            foreach (var key in rooms[room])
                if (visited.Add(key))
                    queue.Enqueue(key);
        }

        return visited.Count == rooms.Count;
    }
}
