using System.Collections.Generic;
using System.Linq;

namespace LeetCode._3._Hard._30._Substring_with_Concatenation_of_All_Words;

public class Solution
{
    public IList<int> FindSubstring(string s, string[] words)
    {
        var wordsDict = GetWordsDict(words);
        var uniqueWords = wordsDict.Keys.ToArray();

        var wordIndexes = GetWordIndexes(s, uniqueWords);
        var wordLength = words[0].Length;
        var wordsLength = (words.Length - 1) * wordLength;
        var queue = new Queue<int>();
        var visited = new int[uniqueWords.Length];
        var maxVisited = uniqueWords.Select(w => wordsDict[w]).ToArray();

        var result = new List<int>();
        for (var start = 0; start < wordLength; start++)
        {
            while (queue.Count > 0)
                visited[queue.Dequeue()]--;

            for (var i = start; i <= s.Length - wordLength; i += wordLength)
                if (wordIndexes.TryGetValue(i, out var wordNumber))
                {
                    while (visited[wordNumber] == maxVisited[wordNumber])
                        visited[queue.Dequeue()]--;
                    visited[wordNumber]++;
                    queue.Enqueue(wordNumber);
                    if (queue.Count == words.Length)
                        result.Add(i - wordsLength);
                }
                else
                    while (queue.Count > 0)
                        visited[queue.Dequeue()]--;
        }

        return result;
    }

    private Dictionary<string, int> GetWordsDict(string[] words)
    {
        var wordsDict = new Dictionary<string, int>();
        for (var i = 0; i < words.Length; i++)
            if (!wordsDict.TryAdd(words[i], 1))
                wordsDict[words[i]]++;
        return wordsDict;
    }

    private Dictionary<int, int> GetWordIndexes(string s, string[] words)
    {
        var wordIndexes = new Dictionary<int, int>();
        for (var i = 0; i < words.Length; i++)
            FillWordIndexes(s, words[i], i, wordIndexes);
        return wordIndexes;
    }

    private void FillWordIndexes(string s, string word, int wordNumber, Dictionary<int, int> wordIndexes)
    {
        var index = s.IndexOf(word);
        while (index != -1)
        {
            wordIndexes.TryAdd(index, wordNumber);
            index = s.IndexOf(word, index + 1);
        }
    }
}