namespace LeetCode._1._Easy._70._Climbing_Stairs;

public class Solution
{
    public int ClimbStairs(int n)
    {
        var a = 1;
        var b = 1;
        var res = 1;
        while (n > 1)
        {
            res = a + b;
            b = a;
            a = res;
            n--;
        }

        return res;
    }
}
