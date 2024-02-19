namespace LeetCode._1._Easy._231._Power_of_Two;

public class Solution
{
    public bool IsPowerOfTwo(int n)
    {
        var k = 1 << 30;
        while (k > 0)
        {
            if (n == k)
                return true;
            k >>= 1;
        }

        return false;
    }
}