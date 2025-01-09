using System.Linq;

namespace LeetCode._1._Easy._2185._Counting_Words_With_a_Given_Prefix;

public class Solution
{
    public int PrefixCount(string[] words, string pref)
    {
        return words.Count(x => x.StartsWith(pref));
    }
}
