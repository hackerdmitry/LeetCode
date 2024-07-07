namespace LeetCode._1._Easy._1518._Water_Bottles;

public class Solution
{
    public int NumWaterBottles(int numBottles, int numExchange)
    {
        var numDrinks = 0;

        while (numBottles >= numExchange)
        {
            numBottles -= numExchange - 1;
            numDrinks += numExchange;
        }

        return numBottles + numDrinks;
    }
}
