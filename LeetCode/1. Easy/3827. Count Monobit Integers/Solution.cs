namespace LeetCode._1._Easy._3827._Count_Monobit_Integers;

public class Solution
{
    public int CountMonobit(int n)
    {
        var a = 0;
        var result = 0;
        while (a <= n)
        {
            result++;
            a = (a << 1) | 1;
        }

        return result;
    }
}