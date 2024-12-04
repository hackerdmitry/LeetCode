namespace LeetCode._2._Middle._2825._Make_String_a_Subsequence_Using_Cyclic_Increments;

public class Solution
{
    public bool CanMakeSubsequence(string str1, string str2)
    {
        var pointer1 = -1;
        var pointer2 = 0;

        while (++pointer1 < str1.Length && pointer2 < str2.Length)
            if (str1[pointer1] == str2[pointer2] ||
                NextLetter(str1[pointer1]) == str2[pointer2])
                pointer2++;

        return pointer2 == str2.Length;
    }

    private char NextLetter(char letter) =>
        letter == 'z' ? 'a' : (char) (letter + 1);
}
