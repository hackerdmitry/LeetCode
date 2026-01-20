namespace LeetCode._1._Easy._58._Length_of_Last_Word;

public class Solution
{
    public int LengthOfLastWord(string s)
    {
        var lastWordLength = s[0] != ' ' ? 1 : 0;
        for (var i = 1; i < s.Length; i++)
            if (s[i] != ' ')
                if (s[i - 1] == ' ')
                    lastWordLength = 1;
                else
                    lastWordLength++;

        return lastWordLength;
    }
}
