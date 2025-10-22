using System;
using System.Collections.Generic;

namespace LeetCode._3._Hard._3347._Maximum_Frequency_of_an_Element_After_Performing_Operations_II;

public class Solution
{
    public int MaxFrequency(int[] nums, int k, int numOperations)
    {
        var stateNums = CreateStateNums(nums, k);
        return GetMaxFrequency(stateNums, numOperations);
    }

    private SortedDictionary<int, State> CreateStateNums(int[] nums, int k)
    {
        var stateNums = new SortedDictionary<int, State>();
        foreach (var num in nums)
        {
            Fill(stateNums, num - k, state => state.Add++);
            Fill(stateNums, num, state => state.Stay++);
            Fill(stateNums, num + k + 1, state => state.Remove++);
        }

        return stateNums;
    }

    private void Fill(SortedDictionary<int, State> stateNums, int key, Action<State> stateAction)
    {
        if (!stateNums.TryGetValue(key, out var state))
            stateNums.Add(key, state = new State());
        stateAction(state);
    }

    private int GetMaxFrequency(SortedDictionary<int, State> stateNums, int numOperations)
    {
        var maxFreqCount = 1;
        var currNumOperations = 0;
        var currFreqCount = 0;
        var tempStayStatesCount = 0;
        foreach (var (_, state) in stateNums)
        {
            // Add
            currNumOperations += state.Add;
            currFreqCount += state.Add;
            // Stay
            currNumOperations -= state.Stay;
            tempStayStatesCount += state.Stay;
            // Remove
            currNumOperations -= state.Remove;
            currFreqCount -= state.Remove;

            if (currNumOperations <= numOperations && maxFreqCount < currFreqCount)
                maxFreqCount = currFreqCount;
            if (currNumOperations > numOperations && maxFreqCount < currFreqCount - (currNumOperations - numOperations))
                maxFreqCount = currFreqCount - (currNumOperations - numOperations);

            currNumOperations += tempStayStatesCount;
            tempStayStatesCount = 0;
        }

        return maxFreqCount;
    }

    private class State
    {
        public int Add { get; set; }
        public int Stay { get; set; }
        public int Remove { get; set; }
    }
}