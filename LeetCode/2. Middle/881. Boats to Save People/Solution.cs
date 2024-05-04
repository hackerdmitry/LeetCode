using System;

namespace LeetCode._2._Middle._881._Boats_to_Save_People;

public class Solution
{
    public int NumRescueBoats(int[] people, int limit)
    {
        Array.Sort(people);

        var result = 0;
        var leftPointer = 0;
        var rightPointer = people.Length - 1;

        while (leftPointer < rightPointer)
        {
            result++;
            if (people[leftPointer] + people[rightPointer--] <= limit)
                leftPointer++;
        }

        if (leftPointer == rightPointer)
            result++;

        return result;
    }
}