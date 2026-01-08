namespace LeetCode._1._Easy._1768._Merge_Strings_Alternately;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        var result = new char[word1.Length + word2.Length];
        var i1 = 0;
        var i2 = 0;

        while (i1 + i2 < result.Length)
        {
            if (i1 < word1.Length)
                result[i1 + i2] = word1[i1++];
            if (i2 < word2.Length)
                result[i1 + i2] = word2[i2++];
        }

        return new string(result);
    }
}
