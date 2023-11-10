using System.Linq;
using System.Text.RegularExpressions;

namespace LeetCode.Extensions;

public static class ParserExtensions
{
    public static int[][] ParseIntArray2d(this string line)
    {
        var matches = Regex.Matches(line, @"(?<=\[)((\-?\d+,?)+)(?=\])");
        return matches
            .Select(x => x
                .Value
                .Split(',')
                .Select(y => int.Parse(y.Trim()))
                .ToArray())
            .ToArray();
    }

    public static int[] ParseIntArray(this string line)
    {
        var array = line.TrimStart('[').TrimEnd(']');
        return array
            .Split(',')
            .Select(x => int.Parse(x.Trim()))
            .ToArray();
    }
}
