namespace LeetCode._1._Easy._605._Can_Place_Flowers;

public class Solution
{
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        var possibleCount = 0;

        if (flowerbed.Length == 1 && flowerbed[0] == 0)
        {
            flowerbed[0] = 1;
            possibleCount++;
        }

        if (flowerbed.Length > 1)
        {
            if (flowerbed[0] == 0 && flowerbed[1] == 0)
            {
                flowerbed[0] = 1;
                possibleCount++;
            }

            if (flowerbed[^1] == 0 && flowerbed[^2] == 0)
            {
                flowerbed[^1] = 1;
                possibleCount++;
            }
        }

        for (var i = 1; i < flowerbed.Length - 1; i++)
        {
            if (flowerbed[i - 1] == 0 && flowerbed[i] == 0 && flowerbed[i + 1] == 0)
            {
                possibleCount++;
                flowerbed[i] = 1;
            }
        }

        return possibleCount >= n;
    }
}
