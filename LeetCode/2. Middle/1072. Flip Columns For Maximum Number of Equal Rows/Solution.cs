using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode._2._Middle._1072._Flip_Columns_For_Maximum_Number_of_Equal_Rows;

public class Solution
{
    private static readonly string zero64 = new('0', 19);

    public int MaxEqualRowsAfterFlips(int[][] matrix)
    {
        var rows = new Dictionary<string, int>();
        foreach (var row in matrix)
        {
            var stringifiedRow = StringifyRow(row);
            if (!rows.TryAdd(stringifiedRow, 1))
                rows[stringifiedRow]++;
        }

        return rows.Max(x => x.Value);
    }

    private string StringifyRow(int[] row)
    {
        var isInversed = row[0] == 1;

        var window = 0L;
        var index = 0;
        var resultString = "";

        while (index < row.Length)
        {
            window <<= 1;
            if ((row[index++] == 1) ^ isInversed)
                window++;
            if (index % 64 == 0 || index == row.Length)
            {
                resultString += window.ToString(zero64);
                window = 0L;
            }


        }

        return resultString;
    }
}
