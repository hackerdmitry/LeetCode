namespace LeetCode._2._Middle._3100._Water_Bottles_II;

public class Solution
{
    public int MaxBottlesDrunk(int numBottles, int numExchange)
    {
        var result = 0;
        var numEmptyBottles = 0;

        while (numBottles > 0)
        {
            numEmptyBottles += numBottles;
            result += numBottles;
            numBottles = 0;
            Exchange();
        }

        return result;

        void Exchange()
        {
            while (numEmptyBottles >= numExchange)
            {
                numEmptyBottles -= numExchange++;
                numBottles++;
            }
        }
    }
}
