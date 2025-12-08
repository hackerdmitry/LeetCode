using System.Linq;

namespace LeetCode._1._Easy._1925._Count_Square_Sum_Triples;

public class Solution
{
    public int CountTriples(int n)
    {
        var result = 0;

        var squares = Enumerable.Range(1, n).Select(x => x * x).ToHashSet();
        var lastSquare = n * n;

        for (var a = 1; a <= n; a++)
            for (var b = a; b <= n; b++)
            {
                var squareC = a * a + b * b;
                if (squareC > lastSquare)
                    break;
                if (squares.Contains(squareC))
                    result += a == b ? 1 : 2;
            }

        return result;
    }
}
