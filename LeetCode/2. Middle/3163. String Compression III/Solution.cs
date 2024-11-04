using System.Text;

namespace LeetCode._2._Middle._3163._String_Compression_III;

public class Solution
{
    public string CompressedString(string word)
    {
        var sb = new StringBuilder();
        var count = 1;
        for (var i = 1; i < word.Length; i++, count++)
            if (word[i - 1] != word[i] || count == 9)
            {
                sb.Append(count);
                sb.Append(word[i - 1]);
                count = 0;
            }

        sb.Append(count);
        sb.Append(word[^1]);
        return sb.ToString();
    }
}