using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCode.Extensions;

public static class WriteLineExtensions
{
    public static void WriteLine<T>(this IList<IList<T>> multidimensionalArray, string prefix = null, string separator = ", ", Func<T, string> writeLineFunc = null)
    {
        Console.WriteLine(HandlePrefix(prefix));
        foreach (var array in multidimensionalArray)
            array.WriteLine(separator: separator, writeLineFunc: writeLineFunc);
    }

    public static void WriteLine<T>(this T[][] multidimensionalArray, string prefix = null, string separator = ", ", Func<T, string> writeLineFunc = null) =>
        ((IList<IList<T>>) multidimensionalArray).WriteLine(prefix, separator, writeLineFunc);

    public static void WriteLine<T>(this IList<T> array, string prefix = null, string separator = ", ", Func<T, string> writeLineFunc = null)
    {
        var list = writeLineFunc != null
            ? array.Select(writeLineFunc).Select(ObjectifyNullOrEmpty)
            : array.Select(ObjectifyNullOrEmpty);
        Console.WriteLine(HandlePrefix(prefix) + $"[{string.Join(separator, list)}]");
    }

    public static void WriteLine<T>(this T[,] matrixArray, string prefix = null, Func<T, string> writeLineFunc = null)
    {
        Console.WriteLine(HandlePrefix(prefix));
        var height = matrixArray.GetLength(0);
        var width = matrixArray.GetLength(1);
        for (var i = 0; i < height; i++)
            Enumerable.Range(0, width).Select(j => matrixArray[i, j]).ToArray().WriteLine(writeLineFunc: writeLineFunc);
    }

    private static string HandlePrefix(string prefix) => prefix == null ? null : prefix + ": ";

    private static string ObjectifyNullOrEmpty<T>(T value)
    {
        if (value == null)
            return "null";

        var str = value as string ?? value.ToString();
        if (str == string.Empty)
            return "empty";

        return str;
    }
}