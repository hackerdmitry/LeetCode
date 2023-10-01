using System.Collections.Generic;
using System.Linq;

namespace LeetCode._389._Find_the_Difference
{
    public class Solution
    {
        public char FindTheDifference(string s, string t)
        {
            var dict = Enumerable.Range('a', 26).ToDictionary(x => (char)x, _ => 0);
            var isS = s.Length > t.Length;
            for (int i = 0; i < (isS ? t.Length : s.Length); i++)
            {
                dict[s[i]]++;
                dict[t[i]]--;
            }

            if (isS)
                dict[s[^1]]++;
            else
                dict[t[^1]]--;

            return dict.First(x => x.Value != 0).Key;
        }
    }
}