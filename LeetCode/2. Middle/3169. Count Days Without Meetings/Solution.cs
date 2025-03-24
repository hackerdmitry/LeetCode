using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._3169._Count_Days_Without_Meetings;

public class Solution
{
    public int CountDays(int days, int[][] meetings)
    {
        var startDict = new Dictionary<int, int>();
        var endDict = new Dictionary<int, int>();
        foreach (var meeting in meetings)
        {
            AddMeeting(startDict, meeting[0]);
            AddMeeting(endDict, meeting[1]);
        }

        return days - CountMeetingDays(startDict, endDict);
    }

    private void AddMeeting(Dictionary<int, int> dict, int meeting)
    {
        if (!dict.TryAdd(meeting, 1))
            dict[meeting]++;
    }

    private int CountMeetingDays(Dictionary<int, int> startDict, Dictionary<int, int> endDict)
    {
        var countMeetingDays = 0;

        var startEnumerator = startDict.OrderBy(x => x.Key).GetEnumerator();
        var endEnumerator = endDict.OrderBy(x => x.Key).GetEnumerator();

        startEnumerator.MoveNext();
        endEnumerator.MoveNext();
        var meetingCount = startEnumerator.Current.Value;
        var firstStart = startEnumerator.Current.Key;

        bool MoveEnd()
        {
            meetingCount -= endEnumerator.Current.Value;
            if (meetingCount == 0)
            {
                countMeetingDays += endEnumerator.Current.Key - firstStart + 1;
                firstStart = startEnumerator.Current.Key;
            }

            return endEnumerator.MoveNext();
        }

        while (startEnumerator.MoveNext())
        {
            while (startEnumerator.Current.Key > endEnumerator.Current.Key)
                MoveEnd();
            meetingCount += startEnumerator.Current.Value;
        }

        while (MoveEnd()) ;

        return countMeetingDays;
    }
}
