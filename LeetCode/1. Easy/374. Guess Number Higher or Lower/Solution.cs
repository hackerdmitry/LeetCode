namespace LeetCode._1._Easy._374._Guess_Number_Higher_or_Lower;

public class Solution : GuessGame
{
    public int GuessNumber(int n)
    {
        var left = 1U;
        var right = (uint) n;

        while (true)
        {
            var mid = (int) ((left + right) / 2);
            var value = guess(mid);
            if (value == 0)
                return mid;
            if (value == -1)
                right = (uint) mid;
            else
                left = left == mid ? left + 1 : (uint) mid;
        }
    }
}