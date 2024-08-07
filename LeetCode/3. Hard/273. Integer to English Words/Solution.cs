using System.Collections.Generic;
using System.Linq;

namespace LeetCode._3._Hard._273._Integer_to_English_Words;

public class Solution
{
    public string NumberToWords(int num)
    {
        if (num == 0)
            return "Zero";

        int GetAndCutLastThreeDigit()
        {
            var lastThreeDigit = num % 1_000;
            num /= 1_000;
            return lastThreeDigit;
        }

        var lastThreeDigit = GetAndCutLastThreeDigit();
        var thousands = GetAndCutLastThreeDigit();
        var millions = GetAndCutLastThreeDigit();
        var billions = GetAndCutLastThreeDigit();

        return string.Join(' ',
            new[]
            {
                GetBillionWords(billions),
                GetMillionWords(millions),
                GetThousandWords(thousands),
                GetThreeDigitWords(lastThreeDigit),
            }.Where(x => x.Length > 0));
    }

    private string GetBillionWords(int billions)
    {
        if (billions == 0)
            return string.Empty;

        return $"{GetThreeDigitWords(billions)} Billion";
    }

    private string GetMillionWords(int millions)
    {
        if (millions == 0)
            return string.Empty;

        return $"{GetThreeDigitWords(millions)} Million";
    }

    private string GetThousandWords(int thousands)
    {
        if (thousands == 0)
            return string.Empty;

        return $"{GetThreeDigitWords(thousands)} Thousand";
    }

    private string GetThreeDigitWords(int threeDigit)
    {
        var hundreds = threeDigit / 100;
        var twoDigit = threeDigit % 100;

        var hundredWord = hundreds == 0
            ? string.Empty
            : $"{GetDigitWord(hundreds)} Hundred";
        return $"{hundredWord} {GetTwoDigitWords(twoDigit)}".Trim();
    }

    private string GetTwoDigitWords(int twoDigit)
    {
        var first = twoDigit / 10;
        var second = twoDigit % 10;

        if (first == 1)
            return second switch
            {
                0 => "Ten",
                1 => "Eleven",
                2 => "Twelve",
                3 => "Thirteen",
                4 => "Fourteen",
                5 => "Fifteen",
                6 => "Sixteen",
                7 => "Seventeen",
                8 => "Eighteen",
                9 => "Nineteen",
            };

        var secondWord = GetDigitWord(second);
        if (first == 0)
            return secondWord;

        var firstWord = first switch
        {
            2 => "Twenty",
            3 => "Thirty",
            4 => "Forty",
            5 => "Fifty",
            6 => "Sixty",
            7 => "Seventy",
            8 => "Eighty",
            9 => "Ninety",
        };

        return $"{firstWord} {secondWord}".Trim();
    }

    private string GetDigitWord(int digit) =>
        digit switch
        {
            1 => "One",
            2 => "Two",
            3 => "Three",
            4 => "Four",
            5 => "Five",
            6 => "Six",
            7 => "Seven",
            8 => "Eight",
            9 => "Nine",
            _ => string.Empty,
        };
}