using System.Text;

namespace LeetCode._2._Middle._1625._Lexicographically_Smallest_String_After_Applying_Operations;

public class Solution
{
    private int maxCountRotate;

    public string FindLexSmallestString(string s, int a, int b)
    {
        CalculateMaxCountRotate(a);
        var canStart = CreateCanStart(s, b);
        var onlyEvenRotate = b % 2 == 0;
        return GetLexSmallest(ToArray(s), a, canStart, onlyEvenRotate);
    }

    private void CalculateMaxCountRotate(int a)
    {
        maxCountRotate = a == 5
            ? 2
            : a % 2 == 0
                ? 5
                : 10;
    }

    private static bool[] CreateCanStart(string s, int b)
    {
        var canStart = new bool[s.Length];
        canStart[0] = true;

        var negB = s.Length - b;
        for (var i = 1; i < s.Length; i++)
            for (var j = 0; j < s.Length; j++)
                if ((i + s.Length * j) % negB == 0)
                {
                    canStart[i] = true;
                    break;
                }

        return canStart;
    }

    private static int[] ToArray(string s)
    {
        var arr = new int[s.Length];
        for (var i = 0; i < arr.Length; i++)
            arr[i] = s[i] - '0';
        return arr;
    }

    private string GetLexSmallest(int[] value, int a, bool[] canStart, bool onlyEvenRotate)
    {
        var result = GetLexSmallestState(value, a, 0, onlyEvenRotate);
        for (var i = 1; i < value.Length; i++)
            if (canStart[i])
            {
                var lexSmallestState = GetLexSmallestState(value, a, i, onlyEvenRotate);
                if (IsLexSmaller(result, lexSmallestState))
                    result = lexSmallestState;
            }

        return result;
    }

    private bool IsLexSmaller(string source, string destination)
    {
        for (var i = 0; i < source.Length; i++)
        {
            if (source[i] < destination[i])
                return false;
            if (source[i] > destination[i])
                return true;
        }

        return false;
    }

    private string GetLexSmallestState(int[] value, int a, int startIndex, bool onlyEvenRotate)
    {
        if (!onlyEvenRotate || startIndex % 2 == 1)
            FullCycleRotate(value, a, startIndex, CountRotateToMinValue(value[startIndex], a));
        var nextStartIndex = (startIndex + 1) % value.Length;
        if (!onlyEvenRotate || nextStartIndex % 2 == 1)
            FullCycleRotate(value, a, nextStartIndex, CountRotateToMinValue(value[nextStartIndex], a));
        return ToString(value, startIndex);
    }

    private int CountRotateToMinValue(int value, int a)
    {
        var minValue = value;
        var countRotateToMinValue = 0;
        for (var i = 1; i <= maxCountRotate; i++)
        {
            value = (value + a) % 10;
            if (value < minValue)
            {
                countRotateToMinValue = i;
                minValue = value;
            }
        }

        return countRotateToMinValue;
    }

    private void FullCycleRotate(int[] value, int a, int startIndex, int countRotate)
    {
        for (var i = startIndex % 2; i < value.Length; i += 2)
            value[i] = Rotate(value[i], a, countRotate);
    }

    private int Rotate(int value, int a, int count)
    {
        while (count-- > 0)
            value = (value + a) % 10;
        return value;
    }

    private string ToString(int[] value, int startIndex)
    {
        var sb = new StringBuilder(value.Length);
        for (var i = 0; i < value.Length; i++)
            sb.Append(value[(i + startIndex) % value.Length]);
        return sb.ToString();
    }
}