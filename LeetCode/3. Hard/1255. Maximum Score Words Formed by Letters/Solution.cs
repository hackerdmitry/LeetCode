using System;
using System.Collections.Generic;

namespace LeetCode._3._Hard._1255._Maximum_Score_Words_Formed_by_Letters;

public class Solution
{
    public int MaxScoreWords(string[] words, char[] letters, int[] score)
    {
        var result = 0;
        var queue = new Queue<State>(1 << words.Length);
        queue.Enqueue(new State(-1, GetLetterCounts(letters), 0));

        while (queue.Count > 0)
        {
            var state = queue.Dequeue();
            var index = state.Index + 1;
            var copyLetters = Copy(state.Letters);

            if (index != words.Length - 1)
                queue.Enqueue(new State(index, state.Letters, state.Sum));

            var stateWithNextWord = CreateState(words, copyLetters, score, index, state.Sum);
            if (stateWithNextWord != null)
            {
                result = Math.Max(stateWithNextWord.Sum, result);
                if (index != words.Length - 1)
                    queue.Enqueue(stateWithNextWord);
            }
        }

        return result;
    }

    private State CreateState(string[] words, int[] letters, int[] score, int index, int sum)
    {
        var word = words[index];
        return Distinct(letters, word)
            ? new State(index, letters, sum + GetBoost(word, score))
            : null;
    }

    private bool Distinct(int[] letters, string word)
    {
        foreach (var letter in word)
        {
            letters[letter - 'a']--;
            if (letters[letter - 'a'] < 0)
                return false;
        }

        return true;
    }

    private int GetBoost(string word, int[] score)
    {
        var boost = 0;
        foreach (var letter in word)
            boost += score[letter - 'a'];
        return boost;
    }

    private int[] Copy(int[] letters)
    {
        var array = new int[letters.Length];
        Array.Copy(letters, array, letters.Length);
        return array;
    }

    private int[] GetLetterCounts(char[] letters)
    {
        var letterCounts = new int[26];
        foreach (var letter in letters)
            letterCounts[letter - 'a']++;

        return letterCounts;
    }

    class State
    {
        public int Index { get; set; }
        public int[] Letters { get; set; }
        public int Sum { get; set; }

        public State(int index, int[] letters, int sum)
        {
            Index = index;
            Letters = letters;
            Sum = sum;
        }
    }
}