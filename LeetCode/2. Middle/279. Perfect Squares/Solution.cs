using System.Linq;

namespace LeetCode._2._Middle._279._Perfect_Squares;

public class Solution
{
    private const int maxN = 10_000;
    private static readonly int[] squares = Enumerable.Range(1, maxN).Select(x => x * x).Where(x => x <= maxN).ToArray();

    public int NumSquares(int n)
    {
        var array = new int[n + 1];

        var maxSquareIndex = squares.Select((x, i) => (x, i)).Where(x => x.x <= n).MaxBy(x => x.x).i;
        for (var i = maxSquareIndex; i >= 0; i--)
        {
            var square = squares[i];
            array[square] = 1;
            for (var j = 0; j < n && j + square <= n; j++)
                if (array[j] != 0 && (array[j + square] == 0 || array[j] + 1 < array[j + square]))
                    array[j + square] = array[j] + 1;
        }

        return array[n];
    }
}