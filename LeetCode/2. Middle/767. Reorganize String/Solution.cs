namespace LeetCode._2._Middle._767._Reorganize_String;

public class Solution
{
    public string ReorganizeString(string s)
    {
        var result = new char[s.Length];
        var array = new int[26];

        foreach (var c in s)
            array[c - 'a']++;

        result[0] = GetMaxLetter(array)!.Value;
        array[result[0] - 'a']--;

        for (var i = 1; i < s.Length; i++)
        {
            var letter = GetMaxLetter(array, result[i-1]);
            if (!letter.HasValue)
                return string.Empty;
            result[i] = letter.Value;
            array[result[i] - 'a']--;
        }

        return new string(result);
    }

    private char? GetMaxLetter(int[] array, char? prevLetter = null)
    {
        var prevIndex = prevLetter - 'a';
        var maxValue = 0;
        char? maxLetter = null;
        for (var i = 0; i < array.Length; i++)
        {
            if (array[i] > maxValue && i != prevIndex)
            {
                maxValue = array[i];
                maxLetter = (char)(i + 'a');
            }
        }

        return maxLetter;
    }
}