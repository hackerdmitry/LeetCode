namespace LeetCode._1._Easy._1688._Count_of_Matches_in_Tournament;

public class Solution
{
    public int NumberOfMatches(int n)
    {
        var result = 0;
        while (n != 1)
        {
            result += n % 2 == 0
                ? n / 2
                : n / 2 + 1;
            n /= 2;
        }

        return result;
    }
}
