using System.Linq;

namespace LeetCode._1._Easy._2000._Reverse_Prefix_of_Word;

public class Solution
{
    public string ReversePrefix(string word, char ch)
    {
        var index = word.IndexOf(ch);
        if (index == -1)
            return word;

        return new string(word.Substring(0, ++index).Reverse().ToArray()) + word.Substring(index);
    }
}