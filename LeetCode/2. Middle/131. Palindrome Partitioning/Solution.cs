using System.Collections.Generic;

namespace LeetCode._2._Middle._131._Palindrome_Partitioning;

public class Solution
{
    public IList<IList<string>> Partition(string s)
    {
        var result = new List<IList<string>>();

        var palindromes = new Dictionary<int, LinkedList<int>>();
        for (var start = 0; start < s.Length; start++)
            for (var end = start; end < s.Length; end++)
                if (IsPalindrome(s, start, end))
                {
                    if (!palindromes.ContainsKey(start))
                        palindromes[start] = new LinkedList<int>();
                    palindromes[start].AddLast(end);
                }

        var queue = new Queue<Node<int>>();
        foreach (var end in palindromes[0])
            queue.Enqueue(new Node<int>(end));

        while (queue.Count > 0)
        {
            var lastEnd = queue.Dequeue();
            if (lastEnd.Value == s.Length - 1)
                result.Add(ToStrings(s, lastEnd));
            else
            {
                var start = lastEnd.Value + 1;
                foreach (var end in palindromes[start])
                    queue.Enqueue(new Node<int>(end, lastEnd));
            }
        }

        return result;
    }

    private bool IsPalindrome(string s, int start, int end)
    {
        while (s[start] == s[end] && start < end)
        {
            start++;
            end--;
        }

        return s[start] == s[end];
    }

    private IList<string> ToStrings(string s, Node<int> lastEnd)
    {
        var result = new string[lastEnd.Length];
        for (var i = result.Length - 1; i >= 0; i--, lastEnd = lastEnd.Prev)
        {
            var start = (lastEnd.Prev?.Value ?? -1) + 1;
            var end = lastEnd.Value + 1;
            var length = end - start;
            result[i] = s.Substring(start, length);
        }

        return result;
    }

    class Node<TValue>
    {
        public int Length { get; set; }
        public TValue Value { get; set; }
        public Node<TValue> Prev { get; set; }

        public Node(TValue value, Node<TValue> prev = null)
        {
            Value = value;
            Prev = prev;
            Length = (prev?.Length ?? 0) + 1;
        }
    }
}
