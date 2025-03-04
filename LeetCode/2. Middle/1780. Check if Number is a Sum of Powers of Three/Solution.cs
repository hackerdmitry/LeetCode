namespace LeetCode._2._Middle._1780._Check_if_Number_is_a_Sum_of_Powers_of_Three;

public class Solution
{
    private readonly int[] powersOfThree = {4_782_969, 1_594_323, 531_441, 177_147, 59_049, 19_683, 6_561, 2_187, 729, 243, 81, 27, 9, 3, 1};

    public bool CheckPowersOfThree(int n)
    {
        foreach (var power in powersOfThree)
            if (n >= power)
                n -= power;
        return n == 0;
    }
}
