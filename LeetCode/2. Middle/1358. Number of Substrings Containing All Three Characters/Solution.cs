using System.Linq;

namespace LeetCode._2._Middle._1358._Number_of_Substrings_Containing_All_Three_Characters;

public class Solution
{
    public int NumberOfSubstrings(string s)
    {
        var letters = new int[3];
        var right = -1;
        var left = 0;
        var result = 0;

        while (++right < s.Length)
        {
            letters[s[right] - 'a']++;
            while (letters.All(x => x > 0))
            {
                result += s.Length - right;
                letters[s[left++] - 'a']--;
            }
        }

        return result;
    }
}