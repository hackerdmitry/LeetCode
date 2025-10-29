namespace LeetCode._1._Easy._3370._Smallest_Number_With_All_Set_Bits;

public class Solution
{
    public int SmallestNumber(int n)
    {
        var x = 1;
        while (x < n)
            x = (x << 1) + 1;
        return x;
    }
}
