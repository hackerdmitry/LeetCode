namespace LeetCode._1._Easy._1935._Maximum_Number_of_Words_You_Can_Type;

public class Solution
{
    public int CanBeTypedWords(string text, string brokenLettersRaw)
    {
        var brokenLetters = new bool[26];
        foreach (var brokenLetter in brokenLettersRaw)
            brokenLetters[brokenLetter - 'a'] = true;

        var result = 0;
        var isFit = true;
        foreach (var c in text)
            if (c == ' ')
            {
                if (isFit)
                    result++;
                isFit = true;
            }
            else if (isFit && brokenLetters[c - 'a'])
                isFit = false;
        if (isFit)
            result++;

        return result;
    }
}