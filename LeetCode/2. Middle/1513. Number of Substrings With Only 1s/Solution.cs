namespace LeetCode._2._Middle._1513._Number_of_Substrings_With_Only_1s;

public class Solution
{
    private const int modulo = 1_000_000_007;

    public int NumSub(string s)
    {
        var result = 0;
        var startIndex = 0;
        var isOne = s[0] == '1';
        for (var i = 1; i < s.Length; i++)
            if (s[i - 1] != s[i])
            {
                if (isOne)
                    result = AddResult(i - startIndex);

                startIndex = i;
                isOne = !isOne;
            }

        if (isOne)
            result = AddResult(s.Length - startIndex);

        return result;

        int AddResult(int length) => (int) ((result + length * (length + 1L) / 2) % modulo);
    }
}