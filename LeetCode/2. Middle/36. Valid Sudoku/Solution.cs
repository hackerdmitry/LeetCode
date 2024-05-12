namespace LeetCode._2._Middle._36._Valid_Sudoku;

public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        for (var i = 0; i < 9; i++)
        {
            for (var j = 0; j < 9; j++)
            {
                var digit = board[i][j];
                if (digit == '.')
                    continue;

                var cornerI = i / 3;
                var cornerJ = j / 3;

                for (var ci = cornerI * 3; ci < (cornerI + 1) * 3; ci++)
                    for (var cj = cornerJ * 3; cj < (cornerJ + 1) * 3; cj++)
                        if (board[ci][cj] == digit && ci != i && cj != j)
                            return false;

                for (var x = 0; x < 9; x++)
                    if (board[x][j] == digit && x != i)
                        return false;

                for (var y = 0; y < 9; y++)
                    if (board[i][y] == digit && y != j)
                        return false;
            }
        }

        return true;
    }
}