namespace LeetCode._1._Easy._1790._Check_if_One_String_Swap_Can_Make_Strings_Equal;

public class Solution
{
    public bool AreAlmostEqual(string s1, string s2)
    {
        var countDiff = 0;
        var ind1 = 0;
        var ind2 = 0;
        for (var i = 0; i < s1.Length; i++)
            if (s1[i] != s2[i])
                switch (countDiff++)
                {
                    case 0:
                        ind1 = i;
                        break;
                    case 1:
                        ind2 = i;
                        break;
                }

        return countDiff == 0 || countDiff == 2 && s1[ind1] == s2[ind2] && s1[ind2] == s2[ind1];
    }
}
