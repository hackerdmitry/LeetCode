namespace LeetCode._2._Middle._7._Reverse_Integer;

public class Solution
{
    public int Reverse(int x)
    {
        var result = 0;
        while (x != 0)
        {
            try
            {
                checked
                {
                    result = result * 10 + x % 10;
                }
            }
            catch
            {
                return 0;
            }

            x /= 10;
        }

        return result;
    }
}