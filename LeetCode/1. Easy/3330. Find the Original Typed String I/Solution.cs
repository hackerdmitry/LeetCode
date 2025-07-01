namespace LeetCode._1._Easy._3330._Find_the_Original_Typed_String_I;

public class Solution
{
    public int PossibleStringCount(string word)
    {
        var result = 1;
        for (var i = 1; i < word.Length; i++)
            if (word[i - 1] == word[i])
                result++;
        return result;
    }
}
