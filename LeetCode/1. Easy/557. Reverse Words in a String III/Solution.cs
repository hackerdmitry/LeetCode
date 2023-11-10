using System.Linq;
using System.Text;

namespace LeetCode._1._Easy._557._Reverse_Words_in_a_String_III
{
    public class Solution
    {
        public string ReverseWords(string s)
        {
            return string.Join(' ', s.Split(' ').Select(word =>
            {
                var sb = new StringBuilder();
                foreach (var letter in word.Reverse())
                    sb.Append(letter);
                return sb;
            }));
        }
    }
}