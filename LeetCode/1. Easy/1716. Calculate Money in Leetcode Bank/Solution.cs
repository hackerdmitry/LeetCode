using System.Linq;

namespace LeetCode._1._Easy._1716._Calculate_Money_in_Leetcode_Bank;

public class Solution
{
    public int TotalMoney(int n)
    {
        return Enumerable.Range(0, n).Sum(x => x / 7 + x % 7 + 1);
    }
}
