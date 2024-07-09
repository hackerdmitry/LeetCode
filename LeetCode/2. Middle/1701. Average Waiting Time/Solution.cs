using System.Linq;

namespace LeetCode._2._Middle._1701._Average_Waiting_Time;

public class Solution
{
    public double AverageWaitingTime(int[][] customers)
    {
        var totalTimeToOrder = 0d;
        var timeToFree = 0;

        foreach (var (arrival, timeToOrder) in customers
                     .Select(x => (Arrival: x[0], TimeToOrder: x[1]))
                     .OrderBy(x => x.Arrival))
        {
            if (arrival >= timeToFree)
                timeToFree = arrival + timeToOrder;
            else
                timeToFree += timeToOrder;

            totalTimeToOrder += timeToFree - arrival;
        }

        return totalTimeToOrder / customers.Length;
    }
}