namespace LeetCode._3._Hard._76._Minimum_Window_Substring;

public class Solution
{
    public string MinWindow(string s, string t)
    {
        var minStart = 0;
        var minLength = int.MaxValue;
        var equal = 0;

        var left = 0;
        var contains = new int[52];
        var need = new int[52];

        foreach (var c in t)
            need[CharToIndex(c)]++;

        for (var right = 0; right < s.Length; right++)
        {
            if (contains[CharToIndex(s[right])] < need[CharToIndex(s[right])])
                equal++;
            contains[CharToIndex(s[right])]++;

            while (left < right && contains[CharToIndex(s[left])] > need[CharToIndex(s[left])])
                contains[CharToIndex(s[left++])]--;

            if (equal == t.Length && right - left + 1 < minLength)
            {
                minStart = left;
                minLength = right - left + 1;
            }
        }

        return equal == t.Length ? s.Substring(minStart, minLength) : string.Empty;
    }

    private int CharToIndex(char c)
    {
        return c <= 'Z' ? c - 'A' + 26 : c - 'a';
    }
}
