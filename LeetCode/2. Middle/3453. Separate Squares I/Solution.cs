using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._3453._Separate_Squares_I;

public class Solution
{
    public double SeparateSquares(int[][] squares)
    {
        var rbTree = new SortedDictionary<int, long>();
        var totalArea = 0L;

        foreach (var square in squares)
        {
            var area = (long) square[2] * square[2];
            totalArea += area;
            if (!rbTree.TryAdd(square[1], square[2]))
                rbTree[square[1]] += square[2];
            if (!rbTree.TryAdd(square[1] + square[2], -square[2]))
                rbTree[square[1] + square[2]] -= square[2];
        }

        var target = totalArea / 2d;
        var (prevY, prevShift) = rbTree.First();
        foreach (var (y, shift) in rbTree.Skip(1))
        {
            if (prevShift > 0)
            {
                var prevArea = (y - prevY) * prevShift;
                if (target >= prevArea)
                    target -= prevArea;
                else
                    return prevY + target / prevShift;

                if (target == 0)
                    return y;
            }

            prevY = y;
            prevShift += shift;
        }

        return prevY + target / prevShift;
    }
}
