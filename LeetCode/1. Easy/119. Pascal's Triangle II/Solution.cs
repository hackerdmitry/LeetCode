using System.Collections.Generic;

namespace LeetCode._119._Pascal_s_Triangle_II
{
    public class Solution
    {
        public IList<int> GetRow(int rowIndex)
        {
            var rows = new List<int[]> { new[] { 1 } };
            for (var i = 1; i < rowIndex + 1; i++)
            {
                rows.Add(new int[i + 1]);
                rows[i][0] = 1;
                rows[i][i] = 1;
                for (var j = 1; j < i; j++)
                {
                    rows[i][j] = rows[i - 1][j - 1] + rows[i - 1][j];
                }
            }

            return rows[rowIndex];
        }
    }
}