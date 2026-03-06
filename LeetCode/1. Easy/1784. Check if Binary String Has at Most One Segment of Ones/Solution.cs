namespace LeetCode._1._Easy._1784._Check_if_Binary_String_Has_at_Most_One_Segment_of_Ones;

public class Solution
{
    public bool CheckOnesSegment(string s)
    {
        var index = -1;
        while (++index < s.Length && s[index] == '1') ;
        if (index < s.Length)
            while (++index < s.Length && s[index] == '0') ;
        return index == s.Length;
    }
}
