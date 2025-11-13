namespace LeetCode._2._Middle._3228._Maximum_Number_of_Operations_to_Move_Ones_to_the_End;

public class Solution
{
    public int MaxOperations(string s)
    {
        var result = 0;
        var step = 0;
        for (var i = 0; i < s.Length; i++)
            if (s[i] == '1')
                step++;
            else if (i != 0 && s[i - 1] != s[i])
                result += step;
        return result;
    }
}
