using System.Collections.Generic;
using System.Linq;

namespace LeetCode._1._Easy._2942._Find_Words_Containing_Character;

public class Solution
{
    public IList<int> FindWordsContaining(string[] words, char x)
    {
        return words
            .Select((word, index) => (word, index))
            .Where(tuple => tuple.word.Contains(x))
            .Select(tuple => tuple.index)
            .ToArray();
    }
}