namespace LeetCode._2._Middle._838._Push_Dominoes;

public class Solution
{
    public string PushDominoes(string dominoes)
    {
        var result = new char[dominoes.Length];
        var rightDuration = new int[dominoes.Length];
        for (var i = 0; i < dominoes.Length; i++)
            if (dominoes[i] == 'R')
                rightDuration[i] = 1;
            else if (i > 0 && dominoes[i] == '.' && rightDuration[i - 1] > 0)
                rightDuration[i] = rightDuration[i - 1] + 1;
        var leftCounter = 0;
        for (var i = dominoes.Length - 1; i >= 0; i--)
            if (dominoes[i] != '.')
            {
                leftCounter = dominoes[i] == 'L' ? 1 : 0;
                result[i] = dominoes[i];
            }
            else
                result[i] = leftCounter > 0
                    ? ++leftCounter == rightDuration[i]
                        ? '.'
                        : leftCounter < rightDuration[i] || rightDuration[i] == 0
                            ? 'L'
                            : 'R'
                    : rightDuration[i] > 0
                        ? 'R'
                        : '.';

        return new string(result);
    }
}