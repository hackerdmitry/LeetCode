using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._1268._Search_Suggestions_System;

public class Solution
{
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
    {
        var trie = new Trie();
        foreach (var product in products)
            trie.AddWord(product);

        var result = new string[searchWord.Length][];
        for (var i = 1; i<=searchWord.Length; i++)
            result[i - 1] = DFSByPrefix(trie.GetByPrefix(searchWord, i), 3).ToArray();
        return result;
    }

    private IEnumerable<string> DFSByPrefix(TrieNode node, int count)
    {
        if (node == null)
            yield break;

        if (node.IsEndOfWord)
        {
            yield return node.Word;
            count--;
            if (count == 0)
                yield break;
        }

        foreach (var trieNode in node.GetChildrenInOrder())
            foreach (var word in DFSByPrefix(trieNode, count))
            {
                yield return word;
                count--;
                if (count == 0)
                    yield break;
            }
    }

    private class Trie
    {
        private readonly TrieNode _root = new(' ');

        public void AddWord(string word)
        {
            var node = _root;
            foreach (var letter in word)
                node = node.AddChild(letter);
            node.SetWord(word);
        }

        public TrieNode GetByPrefix(string word, int length)
        {
            var node = _root;
            for (var i = 0; i < length; i++)
            {
                var letter = word[i];
                node = node.GetChild(letter);
                if (node == null)
                    return null;
            }

            return node;
        }
    }

    private class TrieNode
    {
        private SortedSet<char> filledLetters;
        private TrieNode[] children;

        public char Letter { get; }
        public bool IsEndOfWord => Word != null;
        public string Word { get; private set; }

        public TrieNode(char letter)
        {
            Letter = letter;
        }

        public TrieNode GetChild(char letter)
        {
            return children?[letter - 'a'];
        }

        public TrieNode AddChild(char letter)
        {
            children ??= new TrieNode[26];
            filledLetters ??= new SortedSet<char>();

            var index = letter - 'a';
            var child = children[index];

            if (child == null)
            {
                var childNode = new TrieNode(letter);
                child = children[index] = childNode;
                filledLetters.Add(letter);
            }

            return child;
        }

        public void SetWord(string word)
        {
            Word = word;
        }

        public IEnumerable<TrieNode> GetChildrenInOrder()
        {
            if (filledLetters == null)
                yield break;

            foreach (var letter in filledLetters)
                yield return children[letter - 'a'];
        }
    }
}
