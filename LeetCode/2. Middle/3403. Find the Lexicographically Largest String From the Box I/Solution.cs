using System;

namespace LeetCode._2._Middle._3403._Find_the_Lexicographically_Largest_String_From_the_Box_I;

public class Solution
{
    public string AnswerString(string word, int numFriends)
    {
        if (numFriends == 1)
            return word;

        var splittedWordLength = word.Length - numFriends + 1;
        var maxIndex = FindMaxIndex(word, splittedWordLength);
        return word.Substring(maxIndex, Math.Min(word.Length - maxIndex, splittedWordLength));
    }

    private int FindMaxIndex(string word, int splittedWordLength)
    {
        var maxIndex = 0;

        for (var i = 1; i < word.Length; i++)
        {
            var j = 0;
            while (i + j < word.Length && word[maxIndex + j] == word[i + j] && ++j < splittedWordLength) ;
            if (i + j < word.Length && j != splittedWordLength && word[maxIndex + j] < word[i + j])
                maxIndex = i;
        }

        return maxIndex;
    }
}
