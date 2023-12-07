using System.Linq;

namespace LeetCode._1._Easy._1903._Largest_Odd_Number_in_String;

public class Solution
{
    public string LargestOddNumber(string num)
    {
        var length = num
            .Select((x, i) => (x, i + 1))
            .Reverse()
            .FirstOrDefault<(char x, int i)>(x => (x.x - '0') % 2 == 1, ('\0', 0)).i;
        return num[..length];
    }
}
