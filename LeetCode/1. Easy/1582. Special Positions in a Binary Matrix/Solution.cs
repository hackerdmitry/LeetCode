namespace LeetCode._1._Easy._1582._Special_Positions_in_a_Binary_Matrix;

public class Solution
{
    public int NumSpecial(int[][] mat)
    {
        var result = 0;

        for (var i = 0; i < mat.Length; i++)
        {
            for (var j = 0; j < mat[0].Length; j++)
            {
                if (mat[i][j] == 1)
                {
                    for (var y = 0; y < mat.Length; y++)
                    {
                        if (i == y)
                            continue;
                        if (mat[y][j] == 1)
                            goto next;
                    }
                    for (var x = 0; x < mat[0].Length; x++)
                    {
                        if (j == x)
                            continue;
                        if (mat[i][x] == 1)
                            goto next;
                    }
                    result++;
                }

                next: ;
            }
        }

        return result;
    }
}
