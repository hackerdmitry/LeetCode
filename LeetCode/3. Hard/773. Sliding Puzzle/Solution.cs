using System.Collections.Generic;

namespace LeetCode._3._Hard._773._Sliding_Puzzle;

public class Solution
{
    private const int screenshotOfSolution = 11190;

    public int SlidingPuzzle(int[][] board)
    {
        var variants = new Dictionary<int, int>(720);

        var x = 0;
        var y = 0;
        for (var i = 0; i < board.Length; i++)
            for (var j = 0; j < board[i].Length; j++)
                if (board[i][j] == 0)
                {
                    y = i;
                    x = j;
                    goto breakNestedLoop;
                }

        breakNestedLoop: ;
        MoveStep(x, y, board, 0, variants);
        return variants.GetValueOrDefault(screenshotOfSolution, -1);
    }

    private void MoveStep(int x, int y, int[][] board, int stepsCount, Dictionary<int, int> variants)
    {
        var screenshot = GetScreenshot(board);

        if (variants.ContainsKey(screenshot) && variants[screenshot] <= stepsCount)
            return;
        variants[screenshot] = stepsCount;

        if (y > 0)
        {
            Swap(board, x, y, x, y - 1);
            MoveStep(x, y - 1, board, stepsCount + 1, variants);
            Swap(board, x, y, x, y - 1);
        }

        if (y < 1)
        {
            Swap(board, x, y, x, y + 1);
            MoveStep(x, y + 1, board, stepsCount + 1, variants);
            Swap(board, x, y, x, y + 1);
        }

        if (x > 0)
        {
            Swap(board, x, y, x - 1, y);
            MoveStep(x - 1, y, board, stepsCount + 1, variants);
            Swap(board, x, y, x - 1, y);
        }

        if (x < 2)
        {
            Swap(board, x, y, x + 1, y);
            MoveStep(x + 1, y, board, stepsCount + 1, variants);
            Swap(board, x, y, x + 1, y);
        }
    }

    private void Swap(int[][] board, int x1, int y1, int x2, int y2)
    {
        (board[y1][x1], board[y2][x2]) = (board[y2][x2], board[y1][x1]);
    }

    private int GetScreenshot(int[][] board)
    {
        return 7776 * board[0][0] +
               1296 * board[0][1] +
               216 * board[0][2] +
               36 * board[1][0] +
               6 * board[1][1] +
               board[1][2];
    }
}