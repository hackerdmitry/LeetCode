namespace LeetCode._2._Middle._1759._Count_Number_of_Homogenous_Substrings;

public class Solution
{
    public int CountHomogenous(string s)
    {
        const int module = 1_000_000_007;

        var sum = 1;
        var lastChar = s[0];
        var lastSame = 0;

        for (var i = 1; i < s.Length; i++)
        {
            if (lastChar == s[i])
            {
                sum += i - lastSame + 1;
                sum %= module;
            }
            else
            {
                sum++;
                lastSame = i;
                lastChar = s[i];
            }
        }

        return sum;
    }
}