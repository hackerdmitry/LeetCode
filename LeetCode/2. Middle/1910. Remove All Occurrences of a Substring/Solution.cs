using System.Collections.Generic;
using System.Text;

namespace LeetCode._2._Middle._1910._Remove_All_Occurrences_of_a_Substring;

public class Solution
{
    private readonly LinkedList<State> linkedList = new();

    public string RemoveOccurrences(string s, string part)
    {
        var sb = new StringBuilder(s);

        while (true)
        {
            var index = IndexOf(sb, part);
            if (index == -1)
                return sb.ToString();

            sb.Remove(index, part.Length);
        }
    }

    private int IndexOf(StringBuilder sb, string part)
    {
        linkedList.Clear();

        for (var i = 0; i < sb.Length; i++)
        {
            var state = linkedList.First;
            while (state != null)
            {
                var nextState = state.Next;
                if (part[state.Value.CurrentIndexPart] != sb[i])
                    linkedList.Remove(state);
                else if (++state.Value.CurrentIndexPart == part.Length)
                    return state.Value.StartIndex;
                state = nextState;
            }

            if (sb[i] == part[0])
                if (part.Length == 1)
                    return i;
                else
                    linkedList.AddLast(new State {StartIndex = i, CurrentIndexPart = 1});
        }

        return -1;
    }

    private class State
    {
        public int StartIndex { get; set; }
        public int CurrentIndexPart { get; set; }
    }
}