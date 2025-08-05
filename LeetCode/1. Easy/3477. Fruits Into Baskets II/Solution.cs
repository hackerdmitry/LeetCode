namespace LeetCode._1._Easy._3477._Fruits_Into_Baskets_II;

public class Solution
{
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets)
    {
        var unplaced = 0;
        foreach (var fruit in fruits)
        {
            for (var i = 0; i < baskets.Length; i++)
                if (baskets[i] >= fruit)
                {
                    baskets[i] = 0;
                    goto next;
                }

            unplaced++;
            next: ;
        }

        return unplaced;
    }
}
