namespace LeetCode._1._Easy._2582._Pass_the_Pillow;

public class Solution
{
    public int PassThePillow(int n, int time)
    {
        var toRight = true;
        var i = 1;
        for (; time > 0; time--, i += toRight ? 1 : -1)
            if (toRight && i == n || !toRight && i == 1)
                toRight = !toRight;
        return i;
    }
}
