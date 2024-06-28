using System;
using System.Linq;

namespace LeetCode._2._Middle._2285._Maximum_Total_Importance_of_Roads;

public class Solution
{
    public long MaximumImportance(int n, int[][] roads)
    {
        var array = new int[n];
        foreach (var road in roads)
        {
            array[road[0]]++;
            array[road[1]]++;
        }

        Array.Sort(array);

        var result = 0L;
        for (var importance = 1L; importance <= array.Length; importance++)
            result += importance * array[importance - 1];

        return result;
    }
}
