using System.Collections.Generic;
using System.Linq;

namespace LeetCode._3._Hard._140._Word_Break_II;

public class Solution
{
    public IList<string> WordBreak(string s, IList<string> wordDict)
    {
        var result = new List<string>();

        var wordsByFirstLetter = wordDict
            .GroupBy(x => x[0])
            .ToDictionary(x => x.Key, x => x.ToArray());

        if (!wordsByFirstLetter.ContainsKey(s[0]))
            return result;

        var queue = new Queue<Node>(wordsByFirstLetter[s[0]].Where(x => IsFit(s, 0, x)).Select(x => new Node(x, x.Length)));
        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            if (node.NextIndex == s.Length)
            {
                result.Add(ToString(node, s));
                continue;
            }

            var firstLetter = s[node.NextIndex];
            if (wordsByFirstLetter.TryGetValue(firstLetter, out var words))
                foreach (var fittedWord in words.Where(x => IsFit(s, node.NextIndex, x)))
                    queue.Enqueue(new Node(fittedWord, node.NextIndex + fittedWord.Length, node));
        }

        return result;
    }

    bool IsFit(string s, int start, string word)
    {
        var end = start + word.Length;
        if (end > s.Length)
            return false;

        for (var i = start; i < end; i++)
            if (word[i - start] != s[i])
                return false;

        return true;
    }

    string ToString(Node node, string s)
    {
        var sb = new char[s.Length + node.Length - 1];
        var end = sb.Length;

        while (node != null)
        {
            var start = end - node.Word.Length;
            for (var i = start; i < end; i++)
                sb[i] = node.Word[i - start];
            if (start != 0)
                sb[start - 1] = ' ';
            end = start - 1;

            node = node.Prev;
        }

        return new string(sb);
    }

    class Node
    {
        public string Word { get; set; }
        public int NextIndex { get; set; }
        public Node Prev { get; set; }
        public int Length { get; set; }

        public Node(string word, int nextIndex, Node prev = null)
        {
            Word = word;
            NextIndex = nextIndex;
            Prev = prev;
            Length = (prev?.Length ?? 0) + 1;
        }
    }
}