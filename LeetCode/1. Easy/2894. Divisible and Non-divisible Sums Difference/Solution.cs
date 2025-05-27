namespace LeetCode._1._Easy._2894._Divisible_and_Non_divisible_Sums_Difference;

public class Solution
{
    public int DifferenceOfSums(int n, int m)
    {
        var num1 = 0;
        var num2 = 0;

        for (var x = 1; x <= n; x++)
            if (x % m == 0)
                num2 += x;
            else
                num1 += x;

        return num1 - num2;
    }
}
