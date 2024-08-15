namespace LeetCode._1._Easy._860._Lemonade_Change;

public class Solution
{
    public bool LemonadeChange(int[] bills)
    {
        var count5 = 0;
        var count10 = 0;

        foreach (var bill in bills)
        {
            switch (bill)
            {
                case 5:
                    count5++;
                    break;
                case 10:
                    if (count5 == 0)
                        return false;

                    count5--;
                    count10++;
                    break;
                case 20:
                    if (count5 > 0 && count10 > 0)
                    {
                        count10--;
                        count5--;
                        break;
                    }

                    if (count5 >= 3)
                    {
                        count5 -= 3;
                        break;
                    }

                    return false;
            }
        }

        return true;
    }
}