namespace LeetCode._2._Middle._2109._Adding_Spaces_to_a_String;

public class Solution
{
    public string AddSpaces(string s, int[] spaces)
    {
        var result = new char[s.Length + spaces.Length];
        for (int i = 0, j = 0; i < s.Length; i++)
        {
            if (j < spaces.Length && i == spaces[j])
                result[i + j++] = ' ';
            result[i + j] = s[i];
        }

        return new string(result);
    }
}
