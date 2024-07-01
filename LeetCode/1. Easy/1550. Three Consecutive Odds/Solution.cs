namespace LeetCode._1._Easy._1550._Three_Consecutive_Odds;

public class Solution
{
    public bool ThreeConsecutiveOdds(int[] arr)
    {
        var consecutiveOdd = 0;
        foreach (var a in arr)
        {
            if (a % 2 == 1)
                consecutiveOdd++;
            else
                consecutiveOdd = 0;
            if (consecutiveOdd == 3)
                return true;
        }

        return false;
    }
}
