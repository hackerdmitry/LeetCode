using System.Text;

namespace LeetCode._1._Easy._1323._Maximum_69_Number;

public class Solution
{
    public int Maximum69Number(int num)
    {
        var sb = new StringBuilder(num.ToString());
        for (var i = 0; i < sb.Length; i++)
            if (sb[i] == '6')
            {
                sb[i] = '9';
                break;
            }
        return int.Parse(sb.ToString());
    }
}