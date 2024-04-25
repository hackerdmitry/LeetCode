using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._2901._Longest_Unequal_Adjacent_Groups_Subsequence_II;

public class Solution
{
    public IList<string> GetWordsInLongestSubsequence(string[] words, int[] groups)
    {
        var n = words.Length;
        var cells = new Cell[n];
        for (var i = 0; i < n; i++)
        {
            cells[i] = new Cell { Count = 1, Word = words[i], Group = groups[i], PrevCell = null };
            for (var j = i - 1; j >= 0; j--)
            {
                var isMatch = cells[i].Group != cells[j].Group && SatisfyConditionHammingDistance(cells[i].Word, cells[j].Word);
                var boost = isMatch ? 1 : 0;
                if (isMatch && cells[j].Count + boost > cells[i].Count)
                {
                    cells[i].Count = cells[j].Count + boost;
                    cells[i].PrevCell = cells[j];
                }
            }
        }

        var lastCell = cells.MaxBy(x => x.Count);
        var result = new string[lastCell.Count];
        while (lastCell != null)
        {
            result[lastCell.Count - 1] = lastCell.Word;
            lastCell = lastCell.PrevCell;
        }

        return result;
    }

    private bool SatisfyConditionHammingDistance(string first, string second) =>
        HammingDistance(first, second) == 1;

    private int? HammingDistance(string first, string second)
    {
        if (first.Length != second.Length)
            return null;

        var differencesCount = 0;
        for (var i = 0; i < first.Length; i++)
            if (first[i] != second[i])
                differencesCount++;

        return differencesCount;
    }

    private class Cell
    {
        public int Count { get; set; }
        public string Word { get; set; }
        public int Group { get; set; }
        public Cell PrevCell { get; set; }
    }
}