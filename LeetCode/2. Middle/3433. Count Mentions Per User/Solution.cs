using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._3433._Count_Mentions_Per_User;

public class Solution
{
    public int[] CountMentions(int numberOfUsers, IList<IList<string>> rawEvents)
    {
        var members = CreateMembers(numberOfUsers);
        var events = ParseEvents(rawEvents).OrderBy(x => x.Timestamp).ThenByDescending(x => x is OfflineEvent).ToArray();
        foreach (var @event in events)
            @event.Handle(members);
        return members.Select(x => x.CountMentioned).ToArray();
    }

    private Member[] CreateMembers(int numberOfUsers)
    {
        var members = new Member[numberOfUsers];
        for (var i = 0; i < numberOfUsers; i++)
            members[i] = new Member();
        return members;
    }

    private Event[] ParseEvents(IList<IList<string>> rawEvents)
    {
        var events = new Event[rawEvents.Count];

        for (var i = 0; i < rawEvents.Count; i++)
        {
            var rawEvent = rawEvents[i];
            events[i] = rawEvent[0] switch
            {
                "MESSAGE" => rawEvent[2] switch
                {
                    "ALL" => new MessageAllEvent(rawEvent[1]),
                    "HERE" => new MessageHereEvent(rawEvent[1]),
                    _ => new MessageIdEvent(rawEvent[1], rawEvent[2]),
                },
                "OFFLINE" => new OfflineEvent(rawEvent[1], rawEvent[2]),
                _ => throw new NotImplementedException(),
            };
        }

        return events;
    }

    private class MessageIdEvent : Event
    {
        private readonly string mentionPeople;

        public MessageIdEvent(string timestamp, string mentionPeople) : base(timestamp)
        {
            this.mentionPeople = mentionPeople;
        }

        public override void Handle(Member[] members)
        {
            foreach (var mentionId in mentionPeople.Split(' ').Select(x => int.Parse(x[2..])))
                members[mentionId].ForceMention();
        }
    }

    private class MessageHereEvent : Event
    {
        public MessageHereEvent(string timestamp)
            : base(timestamp) { }

        public override void Handle(Member[] members)
        {
            foreach (var member in members)
                member.TryMention(Timestamp);
        }
    }

    private class MessageAllEvent : Event
    {
        public MessageAllEvent(string timestamp)
            : base(timestamp) { }

        public override void Handle(Member[] members)
        {
            foreach (var member in members)
                member.ForceMention();
        }
    }

    private class OfflineEvent : Event
    {
        private readonly int id;

        public OfflineEvent(string timestamp, string id) : base(timestamp)
        {
            this.id = int.Parse(id);
        }

        public override void Handle(Member[] members)
        {
            members[id].SetOffline(Timestamp);
        }
    }

    private abstract class Event
    {
        public int Timestamp { get; set; }

        protected Event(string timestamp)
        {
            Timestamp = int.Parse(timestamp);
        }

        public abstract void Handle(Member[] members);
    }

    private class Member
    {
        public int CountMentioned { get; private set; }
        private int OfflineTo { get; set; }

        public void SetOffline(int timestamp)
        {
            OfflineTo = timestamp + 60;
        }

        public void ForceMention()
        {
            CountMentioned++;
        }

        public void TryMention(int timestamp)
        {
            if (OfflineTo <= timestamp)
                CountMentioned++;
        }
    }
}