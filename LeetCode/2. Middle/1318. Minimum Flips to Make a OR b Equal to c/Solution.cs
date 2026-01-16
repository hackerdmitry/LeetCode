namespace LeetCode._2._Middle._1318._Minimum_Flips_to_Make_a_OR_b_Equal_to_c;

public class Solution
{
    public int MinFlips(int a, int b, int c)
    {
        var flips = 0;
        for (var i = 0; i < 32; i++)
        {
            var bitA = (a >> i) & 1;
            var bitB = (b >> i) & 1;
            var bitC = (c >> i) & 1;

            if (bitC == 0)
                flips += bitA + bitB;
            else if (bitA == 0 && bitB == 0)
                flips++;
        }

        return flips;
    }
}