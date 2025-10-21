using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._3346._Maximum_Frequency_of_an_Element_After_Performing_Operations_I;

public class Solution
{
    public int MaxFrequency(int[] nums, int k, int numOperations)
    {
        var stateNums = CreateStateNums(nums, k);
        return GetMaxFrequency(stateNums, numOperations);
    }

    private SortedDictionary<int, State[]> CreateStateNums(int[] nums, int k)
    {
        return new SortedDictionary<int, State[]>(nums
            .SelectMany(num => GetStates(num, k))
            .GroupBy(x => x.Item1, x => x.Item2)
            .ToDictionary(x => x.Key, x => x.ToArray()));
    }

    private IEnumerable<(int, State)> GetStates(int num, int k)
    {
        yield return (num - k, State.Add);
        yield return (num, State.Stay);
        yield return (num + k + 1, State.Remove);
    }

    private int GetMaxFrequency(SortedDictionary<int, State[]> stateNums, int numOperations)
    {
        var maxFreqCount = 1;
        var currNumOperations = 0;
        var currFreqCount = 0;
        var tempStayStatesCount = 0;
        foreach (var (_, states) in stateNums)
        {
            foreach (var state in states)
                switch (state)
                {
                    case State.Add:
                        currNumOperations++;
                        currFreqCount++;
                        break;
                    case State.Stay:
                        currNumOperations--;
                        tempStayStatesCount++;
                        break;
                    case State.Remove:
                        currNumOperations--;
                        currFreqCount--;
                        break;
                }

            if (currNumOperations <= numOperations && maxFreqCount < currFreqCount)
                maxFreqCount = currFreqCount;
            if (currNumOperations > numOperations && maxFreqCount < currFreqCount - (currNumOperations - numOperations))
                maxFreqCount = currFreqCount - (currNumOperations - numOperations);

            currNumOperations += tempStayStatesCount;
            tempStayStatesCount = 0;
        }

        return maxFreqCount;
    }

    private enum State
    {
        Add = 1,
        Stay = 2,
        Remove = 3,
    }
}
