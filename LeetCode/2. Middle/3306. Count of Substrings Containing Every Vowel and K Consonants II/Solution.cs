using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._3306._Count_of_Substrings_Containing_Every_Vowel_and_K_Consonants_II;

public class Solution
{
    public long CountOfSubstrings(string word, int k)
    {
        var nodes = CreateNodes(word);
        ClearNotEveryVowel(nodes);
        return CountSuitableConditions(nodes, k);
    }

    private LinkedList<Node> CreateNodes(string word)
    {
        var nodes = new LinkedList<Node>();
        nodes.AddLast(new Node(word[0]));

        foreach (var c in word.Skip(1))
        {
            var isVowel = c is 'a' or 'e' or 'i' or 'o' or 'u';
            if (nodes.Last!.Value.IsVowel ^ isVowel)
                nodes.AddLast(new Node(c));
            else
                nodes.Last.Value.AppendVowel(c);
        }

        return nodes;
    }

    private void ClearNotEveryVowel(LinkedList<Node> nodes)
    {
        var node = nodes.First;
        while (node != null)
            if (node.Value.IsVowel && !node.Value.IsEveryVowel)
            {
                var prev = node.Previous;
                var next = node.Next;
                if (prev != null && next != null)
                {
                    prev.Value.CountConsonants += next.Value.CountConsonants;
                    nodes.Remove(node);
                    node = next.Next;
                    nodes.Remove(next);
                }
                else
                {
                    nodes.Remove(node);
                    node = next;
                }
            }
            else
                node = node.Next;
    }

    private int CountSuitableConditions(LinkedList<Node> nodes, int k)
    {
        var result = 0;
        var node = nodes.First;
        while (node != null)
        {
            if (node.Value.IsEveryVowel)
                if (k == 0)
                    result++;
                else
                {
                    var prevConsonants = node.Previous?.Value.CountConsonants ?? 0;
                    var nextConsonants = node.Next?.Value.CountConsonants ?? 0;
                    if (prevConsonants + nextConsonants >= k)
                    {
                        var maxLeft = Math.Min(prevConsonants, k);
                        var maxRight = Math.Min(nextConsonants, k);
                        result += maxLeft + maxRight;
                    }
                }

            node = node.Next;
        }

        return result;
    }

    private class Node
    {
        public bool IsVowel { get; set; }
        public bool IsEveryVowel => IsVowel && A && E && I && O && U;
        public int CountConsonants { get; set; }

        private bool A { get; set; }
        private bool E { get; set; }
        private bool I { get; set; }
        private bool O { get; set; }
        private bool U { get; set; }

        public Node(char letter)
        {
            if (AppendVowel(letter))
                IsVowel = true;
        }

        public bool AppendVowel(char letter)
        {
            switch (letter)
            {
                case 'a':
                    A = true;
                    return true;
                case 'e':
                    E = true;
                    return true;
                case 'i':
                    I = true;
                    return true;
                case 'o':
                    O = true;
                    return true;
                case 'u':
                    U = true;
                    return true;
            }

            CountConsonants++;
            return false;
        }
    }
}