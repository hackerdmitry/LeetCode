using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._2661._First_Completely_Painted_Row_or_Column;

public class Solution
{
    public int FirstCompleteIndex(int[] arr, int[][] mat)
    {
        var m = mat.Length;
        var n = mat[0].Length;

        var intInfos = new Dictionary<int, (int Y, int X)>();
        var yLeft = Enumerable.Repeat(n, m).ToArray();
        var xLeft = Enumerable.Repeat(m, n).ToArray();
        for (var y = 0; y < m; y++)
            for (var x = 0; x < n; x++)
                intInfos[mat[y][x]] = (y, x);

        for (var i = 0; i < arr.Length; i++)
        {
            var num = arr[i];
            var (y, x) = intInfos[num];
            if (--yLeft[y] == 0 || --xLeft[x] == 0)
                return i;
        }

        return -1;
    }
}
