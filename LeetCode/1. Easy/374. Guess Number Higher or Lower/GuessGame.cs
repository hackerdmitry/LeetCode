using System;

namespace LeetCode._1._Easy._374._Guess_Number_Higher_or_Lower;

public class GuessGame
{
    public int Pick { get; set; }

    protected int guess(int num)
    {
        return Math.Sign(Pick - num);
    }
}