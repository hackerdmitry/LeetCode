using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode._3._Hard._68._Text_Justification;

public class Solution
{
    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        return CreateJustifiedLines(words, maxWidth).ToArray();
    }

    private IEnumerable<string> CreateJustifiedLines(string[] words, int maxWidth)
    {
        var lineWords = new List<string>();
        var wordsLength = 0;
        foreach (var word in words)
        {
            if (wordsLength + lineWords.Count + word.Length > maxWidth)
            {
                yield return JustifyLine(lineWords, maxWidth, wordsLength);
                lineWords.Clear();
                wordsLength = 0;
            }

            wordsLength += word.Length;
            lineWords.Add(word);
        }

        yield return JustifyLine(lineWords, maxWidth, wordsLength, true);
    }

    private string JustifyLine(IList<string> lineWords, int maxWidth, int wordsLength, bool isLeftJustified = false)
    {
        var stringBuilder = new StringBuilder();
        var totalSpaces = maxWidth - wordsLength;
        if (lineWords.Count > 1)
        {
            var gap = isLeftJustified ? " " : new string(' ', totalSpaces / (lineWords.Count - 1));
            var wordsWithExtraGaps = isLeftJustified ? 0 : totalSpaces % (lineWords.Count - 1);
            foreach (var word in lineWords)
            {
                stringBuilder.Append(word);
                if (stringBuilder.Length < maxWidth)
                {
                    stringBuilder.Append(gap);
                    if (wordsWithExtraGaps > 0)
                    {
                        stringBuilder.Append(' ');
                        wordsWithExtraGaps--;
                    }
                }
            }
        }
        else
            stringBuilder.Append(lineWords[0]);

        if (stringBuilder.Length < maxWidth)
            stringBuilder.Append(' ', maxWidth - stringBuilder.Length);

        return stringBuilder.ToString();
    }
}