using System.Linq;

namespace LeetCode._1._Easy._2490._Circular_Sentence;

public class Solution
{
    public bool IsCircularSentence(string sentence)
    {
        var words = sentence.Split(' ');
        return sentence[0] == sentence[^1] && words.SkipLast(1).Zip(words.Skip(1)).All(word => word.First[^1] == word.Second[0]);
    }
}
