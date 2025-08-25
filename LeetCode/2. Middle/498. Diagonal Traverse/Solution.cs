namespace LeetCode._2._Middle._498._Diagonal_Traverse;

public class Solution
{
    public int[] FindDiagonalOrder(int[][] mat)
    {
        var y = 0;
        var x = 0;
        var isUpRight = true;
        var m = mat.Length;
        var n = mat[0].Length;
        var result = new int[m * n];

        for (var i = 0; i < result.Length; i++)
        {
            result[i] = mat[y][x];
            if (isUpRight)
                if (y == 0 || x == n - 1)
                {
                    isUpRight = !isUpRight;
                    if (x == n - 1)
                        y++;
                    else
                        x++;
                }
                else
                {
                    y--;
                    x++;
                }
            else if (y == m - 1 || x == 0)
            {
                isUpRight = !isUpRight;
                if (y == m - 1)
                    x++;
                else
                    y++;
            }
            else
            {
                y++;
                x--;
            }
        }

        return result;
    }
}
