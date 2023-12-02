using System.Linq;

namespace LeetCode._1._Easy._1160._Find_Words_That_Can_Be_Formed_by_Characters;

public class Solution
{
    public int CountCharacters(string[] words, string chars)
    {
        var charsDict = chars.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

        var result = 0;
        var alphabet = new int[26];
        foreach (var word in words)
        {
            for (var i = 0; i < word.Length; i++)
                alphabet[word[i] - 'a']++;

            var isFit = true;
            for (var i = 0; i < alphabet.Length; i++)
            {
                var letter = (char) ('a' + i);
                if (alphabet[i] > 0 && (!charsDict.ContainsKey(letter) || charsDict[letter] < alphabet[i]))
                    isFit = false;
                alphabet[i] = 0;
            }

            if (isFit)
                result += word.Length;
        }

        return result;
    }
}
