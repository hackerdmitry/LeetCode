using System.Collections.Generic;

namespace LeetCode._2._Middle._648._Replace_Words;

public class Solution
{
    public string ReplaceWords(IList<string> dictionary, string sentence)
    {
        var words = sentence.Split(' ');
        var root = new Node(false);
        foreach (var dictionaryWord in dictionary)
            AddDictionaryWord(dictionaryWord, root);

        for (var i = 0; i < words.Length; i++)
        {
            var word = words[i];
            var node = root;
            for (var j = 0; j < word.Length; j++)
            {
                if (!node.TryGetNext(word[j], out node))
                    break;
                if (node.IsEnd)
                {
                    words[i] = word.Remove(j + 1);
                    break;
                }
            }
        }

        return string.Join(' ', words);
    }

    private void AddDictionaryWord(string dictionaryWord, Node root)
    {
        var node = root;
        for (var i = 0; i < dictionaryWord.Length; i++)
        {
            var letter = dictionaryWord[i];
            node = node.Add(letter, i + 1 == dictionaryWord.Length);
        }
    }

    class Node
    {
        public IDictionary<char, Node> Next { get; set; }
        public bool IsEnd { get; set; }

        public Node(bool isEnd)
        {
            IsEnd = isEnd;
        }

        public Node Add(char letter, bool isEnd)
        {
            if (Next?.TryGetValue(letter, out var node) == true)
            {
                node.IsEnd |= isEnd;
                return node;
            }

            node = new Node(isEnd);
            if (Next == null)
                Next = new Dictionary<char, Node> { [letter] = node };
            else
                Next.Add(letter, node);
            return node;
        }

        public bool TryGetNext(char letter, out Node next)
        {
            if (Next == null)
            {
                next = null;
                return false;
            }

            return Next.TryGetValue(letter, out next);
        }
    }
}