using System.Linq;

namespace LeetCode._2._Middle._1980._Find_Unique_Binary_String;

public class Solution
{
    public string FindDifferentBinaryString(string[] nums)
    {
        var numsSet = nums.Select(ToDecimalInt).ToHashSet();
        var n = nums[0].Length;
        for (var i = 0; ; i++)
        {
            if (!numsSet.Contains(i))
                return ToBinaryString(i, n);
        }
    }

    private int ToDecimalInt(string num)
    {
        var result = 0;
        var factor = 1;
        for (var i = num.Length - 1; i >= 0; i--)
        {
            if (num[i] == '1')
                result += factor;
            factor *= 2;
        }

        return result;
    }

    private string ToBinaryString(int num, int n)
    {
        var result = new char[n];
        for (var i = result.Length - 1; i >= 0; i--)
        {
            result[i] = num % 2 == 0 ? '0' : '1';
            num /= 2;
        }

        return new string(result);
    }
}
