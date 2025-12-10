using System.Linq;

namespace LeetCode._2._Middle._3577._Count_the_Number_of_Computer_Unlocking_Permutations;

public class Solution
{
    private const int modulo = 1_000_000_007;

    public int CountPermutations(int[] complexity)
    {
        return ValidDecrypt(complexity)
            ? SumPermutations(complexity.Length - 1)
            : 0;
    }

    private int SumPermutations(int count)
    {
        var result = (long) count--;

        while (count > 1)
            result = result * count-- % modulo;

        return (int) result;
    }

    private bool ValidDecrypt(int[] complexity)
    {
        var decrypted = complexity[0];
        return complexity.Skip(1).All(x => decrypted < x);
    }
}