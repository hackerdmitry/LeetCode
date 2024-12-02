using System.Linq;

namespace LeetCode._1._Easy._1455._Check_If_a_Word_Occurs_As_a_Prefix_of_Any_Word_in_a_Sentence;

public class Solution
{
    public int IsPrefixOfWord(string sentence, string searchWord)
    {
        if (sentence.StartsWith(searchWord))
            return 1;

        var index = sentence.IndexOf(' ' + searchWord);
        if (index == -1)
            return -1;

        return sentence.Take(index).Count(x => x == ' ') + 2;
    }
}
