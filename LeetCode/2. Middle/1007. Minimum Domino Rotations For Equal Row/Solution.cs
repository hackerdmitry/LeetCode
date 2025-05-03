using System.Linq;

namespace LeetCode._2._Middle._1007._Minimum_Domino_Rotations_For_Equal_Row;

public class Solution
{
    public int MinDominoRotations(int[] tops, int[] bottoms)
    {
        var minTop = new int[6];
        var minBottom = new int[6];

        for (var i = 0; i < tops.Length; i++)
        {
            for (var j = 0; j < 6; j++)
                if (minTop[j] != -1 && tops[i] != j + 1)
                    minTop[j] = bottoms[i] == j + 1
                        ? minTop[j] + 1
                        : -1;
            for (var j = 0; j < 6; j++)
                if (minBottom[j] != -1 && bottoms[i] != j + 1)
                    minBottom[j] = tops[i] == j + 1
                        ? minBottom[j] + 1
                        : -1;
        }

        return minTop.Union(minBottom)
            .Where(x => x != -1)
            .OrderBy(x => x)
            .FirstOrDefault(-1);
    }
}