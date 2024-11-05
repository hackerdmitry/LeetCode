namespace LeetCode._2._Middle._2914._Minimum_Number_of_Changes_to_Make_Binary_String_Beautiful;

public class Solution
{
    public int MinChanges(string s)
    {
        var count = 0;
        for (var i = 0; i < s.Length; i += 2)
            if (s[i] != s[i + 1])
                count++;

        return count;
    }
}
