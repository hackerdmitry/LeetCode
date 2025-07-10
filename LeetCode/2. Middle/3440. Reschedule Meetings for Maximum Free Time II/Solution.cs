using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._3440._Reschedule_Meetings_for_Maximum_Free_Time_II;

public class Solution
{
    public int MaxFreeTime(int eventTime, int[] startTime, int[] endTime)
    {
        var meetings = CreateMeetings(startTime, endTime);
        var topFreeTimes = FillTopFreeTimes(eventTime, meetings);
        return FindLongestContinuousPeriod(meetings, topFreeTimes, eventTime);
    }

    private Meeting[] CreateMeetings(int[] startTime, int[] endTime)
    {
        var meetings = new Meeting[startTime.Length];
        for (var i = 0; i < startTime.Length; i++)
            meetings[i] = new Meeting
            {
                Start = startTime[i],
                End = endTime[i],
                PrevMeeting = i == 0 ? null : meetings[i - 1],
            };
        for (var i = 0; i < startTime.Length; i++)
            meetings[i].NextMeeting = i == startTime.Length - 1 ? null : meetings[i + 1];
        return meetings;
    }

    private FreeTime[] FillTopFreeTimes(int eventTime, Meeting[] meetings)
    {
        var freeTimes = new PriorityQueue<FreeTime, int>(3);

        void TryToUpdateFreeTimes(int startFreeTime, int durationFreeTime, Meeting prevMeeting, Meeting nextMeeting)
        {
            if (durationFreeTime > 0 && (freeTimes.Count < 3 || freeTimes.Peek().Duration < durationFreeTime))
            {
                if (freeTimes.Count == 3)
                    freeTimes.Dequeue();

                freeTimes.Enqueue(new FreeTime
                    {
                        Start = startFreeTime,
                        Duration = durationFreeTime,
                        PrevMeeting = prevMeeting,
                        NextMeeting = nextMeeting,
                    },
                    durationFreeTime);
            }
        }

        var prevMeeting = (Meeting) null;
        foreach (var meeting in meetings)
        {
            var durationFreeTime = meeting.Start - (prevMeeting?.End ?? 0);
            TryToUpdateFreeTimes(meeting.Start, durationFreeTime, prevMeeting, meeting);
            prevMeeting = meeting;
        }

        TryToUpdateFreeTimes(meetings[^1].End, eventTime - meetings[^1].End, prevMeeting, null);

        return Values(freeTimes).OrderByDescending(x => x.Duration).ToArray();
    }

    private IEnumerable<FreeTime> Values(PriorityQueue<FreeTime, int> freeTimes)
    {
        while (freeTimes.Count > 0)
            yield return freeTimes.Dequeue();
    }

    private int FindLongestContinuousPeriod(Meeting[] meetings, FreeTime[] topFreeTimes, int eventTime)
    {
        var result = 0;

        foreach (var meeting in meetings)
        {
            var freeTimePeriod =
                meeting.Start - (meeting.PrevMeeting?.End ?? 0) +
                (meeting.NextMeeting?.Start ?? eventTime) - meeting.End;
            var freeTime = FindFitFreeTime(meeting, topFreeTimes);
            if (freeTime != null)
                freeTimePeriod += meeting.End - meeting.Start;
            result = Math.Max(result, freeTimePeriod);
        }

        return result;
    }

    private FreeTime FindFitFreeTime(Meeting meeting, FreeTime[] topFreeTimes)
    {
        foreach (var freeTime in topFreeTimes)
            if (meeting.Start != freeTime.PrevMeeting?.Start &&
                meeting.Start != freeTime.NextMeeting?.Start &&
                freeTime.Duration >= meeting.End - meeting.Start)
                return freeTime;
        return null;
    }

    private class FreeTime
    {
        public int Start { get; set; }
        public int Duration { get; set; }

        public Meeting PrevMeeting { get; set; }
        public Meeting NextMeeting { get; set; }
    }

    private class Meeting
    {
        public int Start { get; set; }
        public int End { get; set; }

        public Meeting PrevMeeting { get; set; }
        public Meeting NextMeeting { get; set; }
    }
}