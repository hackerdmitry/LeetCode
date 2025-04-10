namespace LeetCode._3._Hard._2999._Count_the_Number_of_Powerful_Integers;

public class Solution
{
    public long NumberOfPowerfulInt(long start, long finish, int limit, string s)
    {
        var suffix = long.Parse(s);
        var lenSuffix = s.Length;
        var minPowerful = GetMinPowerful(start, limit, suffix, lenSuffix);
        var maxPowerful = GetMaxPowerful(finish, limit, suffix, lenSuffix);
        return maxPowerful == -1 || minPowerful > maxPowerful
            ? 0
            : maxPowerful - minPowerful + 1;
    }

    private long GetMinPowerful(long start, int limit, long suffix, int lenSuffix)
    {
        var (prefixStart, suffixStart) = Separate(start, lenSuffix);
        return NormalizeMinBoundary(suffixStart <= suffix ? prefixStart : prefixStart + 1, limit);
    }

    private long GetMaxPowerful(long finish, int limit, long suffix, int lenSuffix)
    {
        if (finish < suffix)
            return -1;

        var (prefixFinish, suffixFinish) = Separate(finish, lenSuffix);
        return NormalizeMaxBoundary(suffixFinish < suffix ? prefixFinish - 1 : prefixFinish, limit);
    }

    private (long, long) Separate(long number, int lenSuffix)
    {
        var factor = 1L;
        var suffix = 0L;
        for (var i = 0; i < lenSuffix; i++)
        {
            suffix += factor * (number % 10);
            number /= 10;
            factor *= 10;
        }

        return (number, suffix);
    }

    private long NormalizeMinBoundary(long number, int limit)
    {
        var factor = 1L;
        for (var copyNumber = number; copyNumber >= 10; copyNumber /= 10, factor *= 10) ;

        var normalizedNumber = 0L;
        while (number > 0)
        {
            var digit = number / factor % 10;

            if (digit > limit)
            {
                normalizedNumber += factor * 10;
                break;
            }

            normalizedNumber += factor * digit;
            number %= factor;
            factor /= 10;
        }

        return ConvertToBase(normalizedNumber, limit + 1);
    }

    private long NormalizeMaxBoundary(long number, int limit)
    {
        var factor = 1L;
        for (var copyNumber = number; copyNumber >= 10; copyNumber /= 10, factor *= 10) ;

        var normalizedNumber = 0L;
        while (number > 0)
        {
            var digit = number / factor % 10;

            if (digit > limit)
            {
                while (number > 0)
                {
                    normalizedNumber += factor * limit;
                    factor /= 10;
                    number /= 10;
                }

                break;
            }

            normalizedNumber += factor * digit;
            number %= factor;
            factor /= 10;
        }

        return ConvertToBase(normalizedNumber, limit + 1);
    }

    private long ConvertToBase(long number, int fromBase)
    {
        var factor = 1L;
        var result = 0L;
        while (number > 0)
        {
            result += factor * (number % 10);
            factor *= fromBase;
            number /= 10;
        }

        return result;
    }
}