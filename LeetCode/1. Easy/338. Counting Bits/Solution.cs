namespace LeetCode._1._Easy._338._Counting_Bits;

public class Solution
{
    public int[] CountBits(int n)
    {
        var result = new int[n + 1];
        if (n == 0)
            return result;

        result[1] = 1;
        var powerOfTwo = 1;
        for (var x = 2; x <= n; x++)
            if (x == powerOfTwo * 2)
            {
                powerOfTwo = x;
                result[x] = 1;
            }
            else
                result[x] = result[x - powerOfTwo] + 1;

        return result;
    }
}