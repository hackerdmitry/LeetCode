using System.Collections.Generic;

namespace LeetCode._2._Middle._3829._Design_Ride_Sharing_System;

public class RideSharingSystem
{
    private readonly int[] unavailableMatch = {-1, -1};

    private readonly Dictionary<int, int> cancelledRiders = new();
    private readonly Dictionary<int, int> ridersDict = new();

    private readonly Queue<int> riders = new();
    private readonly Queue<int> drivers = new();

    public void AddRider(int riderId)
    {
        if (!ridersDict.TryAdd(riderId, 1))
            ridersDict[riderId]++;
        riders.Enqueue(riderId);
    }

    public void AddDriver(int driverId)
    {
        drivers.Enqueue(driverId);
    }

    public int[] MatchDriverWithRider()
    {
        while (riders.Count > 0 && cancelledRiders.TryGetValue(riders.Peek(), out var cancelledRider) && cancelledRider > 0)
            riders.Dequeue();

        if (riders.Count > 0 && drivers.Count > 0)
        {
            var riderId = riders.Dequeue();
            var driverId = drivers.Dequeue();
            ridersDict[riderId]--;
            return new[] {driverId, riderId};
        }

        return unavailableMatch;
    }

    public void CancelRider(int riderId)
    {
        if (ridersDict.TryGetValue(riderId, out var ridersCount))
            cancelledRiders[riderId] = ridersCount;
    }
}