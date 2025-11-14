namespace LeetCode._2._Middle._2536._Increment_Submatrices_by_One;

public class Solution
{
    public int[][] RangeAddQueries(int n, int[][] queries)
    {
        var result = new int[n][];
        for (var y = 0; y < n; y++)
            result[y] = new int[n];

        foreach (var query in queries)
        {
            result[query[0]][query[1]]++;
            if (query[2] + 1 < n)
                result[query[2] + 1][query[1]]--;
            if (query[3] + 1 < n)
                result[query[0]][query[3] + 1]--;
            if (query[2] + 1 < n && query[3] + 1 < n)
                result[query[2] + 1][query[3] + 1]++;
        }

        for (var x = 1; x < n; x++)
            result[0][x] += result[0][x - 1];
        for (var y = 1; y < n; y++)
        {
            result[y][0] += result[y - 1][0];
            for (var x = 1; x < n; x++)
                result[y][x] += result[y][x - 1] + result[y - 1][x] - result[y - 1][x - 1];
        }

        return result;
    }
}
