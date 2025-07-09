using System;
using System.Collections.Generic;

namespace LeetCode._2._Middle._3439._Reschedule_Meetings_for_Maximum_Free_Time_I;

public class Solution
{
    public int MaxFreeTime(int eventTime, int k, int[] startTime, int[] endTime)
    {
        var businesses = CreateBusinesses(eventTime, startTime, endTime);
        return GetMaxUnionDurationFreeTime(businesses, k);
    }

    List<IBusiness> CreateBusinesses(int eventTime, int[] startTime, int[] endTime)
    {
        var result = new List<IBusiness>();
        var timeMoment = 0;

        for (var i = 0; i < startTime.Length; i++)
        {
            var currentTime = startTime[i];
            if (currentTime > timeMoment)
                result.Add(new FreeTime{Duration = currentTime - timeMoment});
            timeMoment = endTime[i];
            if (result.Count > 0 && result[^1] is Meeting lastMeeting)
                lastMeeting.Count++;
            else
                result.Add(new Meeting{Count = 1});
        }

        if (eventTime > timeMoment)
            result.Add(new FreeTime{Duration = eventTime - timeMoment});

        return result;
    }

    int GetMaxUnionDurationFreeTime(List<IBusiness> businesses, int k)
    {
        var startIndex = 0;
        var state = new State();
        var maxDuration = 0;
        foreach (var businessToAdd in businesses)
        {
            AddBusiness(businessToAdd, state);
            maxDuration = Math.Max(maxDuration, state.Duration);
            while (state.MeetingCount > k)
                RemoveBusiness(businesses[startIndex++], state);
        }

        return maxDuration;
    }

    void AddBusiness(IBusiness business, State state)
    {
        if (business is FreeTime freeTime)
            state.Duration += freeTime.Duration;
        else if (business is Meeting meeting)
            state.MeetingCount += meeting.Count;
    }

    void RemoveBusiness(IBusiness business, State state)
    {
        if (business is FreeTime freeTime)
            state.Duration -= freeTime.Duration;
        else if (business is Meeting meeting)
            state.MeetingCount -= meeting.Count;
    }

    class State
    {
        public int MeetingCount { get; set; }
        public int Duration { get; set; }
    }

    class FreeTime : IBusiness
    {
        public int Duration { get; set; }
    }

    class Meeting : IBusiness
    {
        public int Count { get; set; }
    }

    interface IBusiness { }
}
