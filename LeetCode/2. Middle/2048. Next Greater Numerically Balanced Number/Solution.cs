using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._2048._Next_Greater_Numerically_Balanced_Number;

public class Solution
{
    private const int maxNumber = 1_224_444;

    public int NextBeautifulNumber(int n)
    {
        return GetNumericallyBalancedNumbers(new BalanceNumber(0, 1, 2, 3, 4, 5, 6))
            .OrderBy(x => x)
            .First(x => x > n);
    }

    private IEnumerable<int> GetNumericallyBalancedNumbers(BalanceNumber number)
    {
        for (var digit = 1; digit <= 6; digit++)
            if (CanAddDigit(number, digit))
            {
                var nextNumber = AddDigit(number, digit);
                if (nextNumber.Number <= maxNumber)
                {
                    if (IsNumericallyBalanced(nextNumber))
                        yield return nextNumber.Number;
                    foreach (var numericallyBalancedNumber in GetNumericallyBalancedNumbers(nextNumber))
                        yield return numericallyBalancedNumber;
                }
            }
    }

    private bool CanAddDigit(BalanceNumber number, int digit) =>
        digit switch
        {
            1 => number.One > 0,
            2 => number.Two > 0,
            3 => number.Three > 0,
            4 => number.Four > 0,
            5 => number.Five > 0,
            6 => number.Six > 0,
        };

    private BalanceNumber AddDigit(BalanceNumber number, int digit) =>
        new(
            number.Number * 10 + digit,
            digit == 1 ? number.One - 1 : number.One,
            digit == 2 ? number.Two - 1 : number.Two,
            digit == 3 ? number.Three - 1 : number.Three,
            digit == 4 ? number.Four - 1 : number.Four,
            digit == 5 ? number.Five - 1 : number.Five,
            digit == 6 ? number.Six - 1 : number.Six
        );

    private bool IsNumericallyBalanced(BalanceNumber number) =>
        number.One is 1 or 0 &&
        number.Two is 2 or 0 &&
        number.Three is 3 or 0 &&
        number.Four is 4 or 0 &&
        number.Five is 5 or 0 &&
        number.Six is 6 or 0;

    private record BalanceNumber(
        int Number,
        int One,
        int Two,
        int Three,
        int Four,
        int Five,
        int Six
    );
}