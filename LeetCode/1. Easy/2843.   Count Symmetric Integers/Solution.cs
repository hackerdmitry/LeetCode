namespace LeetCode._1._Easy._2843.___Count_Symmetric_Integers;

public class Solution
{
    public int CountSymmetricIntegers(int low, int high)
    {
        var count = 0;
        for (var num = low; num <= high; num++)
            switch (num)
            {
                case >= 10 and <= 99:
                    if (num / 10 == num % 10)
                        count++;
                    break;
                case >= 1000 and <= 9999:
                    if (num / 1000 + num / 100 % 10 == num % 100 / 10 + num % 10)
                        count++;
                    break;
            }

        return count;
    }
}