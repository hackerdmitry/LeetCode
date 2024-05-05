using System;
using System.Linq;

namespace LeetCode.Extensions;

public static class WriteLineExtensions
{
    public static void WriteLine<T>(this T[] array, string prefix = null, Func<T, string> writeLineFunc = null)
    {
        Console.WriteLine(
            HandlePrefix(prefix) +
            $"[{string.Join(", ", writeLineFunc != null ? array.Select(writeLineFunc) : array)}]"
        );
    }

    public static void WriteLine<T>(this T[][] multidimensionalArray, string prefix = null, Func<T, string> writeLineFunc = null)
    {
        Console.WriteLine(HandlePrefix(prefix));
        foreach (var array in multidimensionalArray)
            array.WriteLine(writeLineFunc: writeLineFunc);
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
}