using System.Linq;

namespace LeetCode._2._Middle._3227._Vowels_Game_in_a_String;

public class Solution
{
    public bool DoesAliceWin(string s)
    {
        return s.Any(x => x is 'a' or 'e' or 'i' or 'o' or 'u');
    }
}