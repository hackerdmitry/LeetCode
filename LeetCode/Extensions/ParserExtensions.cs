using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace LeetCode.Extensions;

public static class ParserExtensions
{
    public static int ParseInt(this string line)
    {
        return int.Parse(line);
    }

    public static long ParseLong(this string line)
    {
        return long.Parse(line);
    }

    public static int[][] ParseIntArray2d(this string line)
    {
        if (line == "[]")
            return Array.Empty<int[]>();

        var matches = Regex.Matches(line, @"(?<=\[)((\-?\d+,?)*)(?=\])");
        return matches
            .Select(x => x.Value.Trim())
            .Select(
                x => x == string.Empty
                    ? Array.Empty<int>()
                    : x.Split(',')
                        .Select(y => int.Parse(y.Trim()))
                        .ToArray())
            .ToArray();
    }

    public static string[][] ParseStringArray2d(this string line)
    {
        var matches = Regex.Matches(line, @"(?<=\[)((""[^""]*?"",?)+)(?=\])");
        return matches
            .Select(
                x => x
                    .Value
                    .Split(',')
                    .Select(y => y.Trim().Trim('"'))
                    .ToArray())
            .ToArray();
    }

    public static char[][] ParseCharArray2d(this string line)
    {
        var matches = Regex.Matches(line, @"(?<=\[)(('[^']*?',?)+)(?=\])");
        return matches
            .Select(
                x => x
                    .Value
                    .Split(',')
                    .Select(y => char.Parse(y.Trim().Trim('\'')))
                    .ToArray())
            .ToArray();
    }

    public static int[] ParseIntArray(this string line)
    {
        line = line.TrimStart('[').TrimEnd(']');
        if (string.IsNullOrWhiteSpace(line))
            return Array.Empty<int>();

        return line
            .Split(',')
            .Select(x => int.Parse(x.Trim()))
            .ToArray();
    }

    public static int?[] ParseNullIntArray(this string line)
    {
        if (line == "[]")
            return Array.Empty<int?>();

        var array = line.TrimStart('[').TrimEnd(']');
        return array
            .Split(',')
            .Select(x => x.Trim())
            .Select(x => x == "null" ? (int?) null : int.Parse(x))
            .ToArray();
    }

    public static string[] ParseStringArray(this string line, char literalString = '"')
    {
        var array = line.TrimStart('[').TrimEnd(']');
        if (array == string.Empty)
            return Array.Empty<string>();

        return array
            .Split(',')
            .Select(x => Regex.Match(x, @$"^\s*{literalString}(.*){literalString}\s*$").Groups[1].Value)
            .ToArray();
    }

    public static bool[] ParseBoolArray(this string line)
    {
        line = line.TrimStart('[').TrimEnd(']');
        if (string.IsNullOrWhiteSpace(line))
            return Array.Empty<bool>();

        return line
            .Split(',')
            .Select(x => bool.Parse(x.Trim()))
            .ToArray();
    }

    public static double[] ParseDoubleArray(this string line)
    {
        line = line.TrimStart('[').TrimEnd(']');
        if (string.IsNullOrWhiteSpace(line))
            return Array.Empty<double>();

        return line
            .Split(',')
            .Select(x => double.Parse(x.Trim(), CultureInfo.InvariantCulture))
            .ToArray();
    }
}