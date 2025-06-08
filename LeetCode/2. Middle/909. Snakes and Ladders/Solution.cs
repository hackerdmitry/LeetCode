using System.Collections.Generic;

namespace LeetCode._2._Middle._909._Snakes_and_Ladders;

public class Solution
{
    public int SnakesAndLadders(int[][] board)
    {
        var normalizedBoard = NormalizeBoard(board);
        return GetMinCountRollDices(normalizedBoard);
    }

    private int[] NormalizeBoard(int[][] board)
    {
        var n = board.Length;
        var m = board[0].Length;
        var result = new int[m * n];
        var resultIndex = 0;

        var isStartFromBegin = true;
        for (var i = n - 1; i >= 0; i--)
        {
            for (var j = isStartFromBegin ? 0 : m - 1;
                 isStartFromBegin ? j < m : j >= 0;
                 j += isStartFromBegin ? 1 : -1)
                result[resultIndex++] = board[i][j] == -1 ? -1 : board[i][j] - 1;
            isStartFromBegin = !isStartFromBegin;
        }

        for (var i = 0; i < result.Length; i++)
            SetShortPath(result, i);

        return result;
    }

    private int GetMinCountRollDices(int[] board)
    {
        var minRollDices = new int[board.Length];
        for (var i = 0; i < minRollDices.Length; i++)
            minRollDices[i] = -1;

        var queue = new Queue<(int index, int countRollDices)>();
        queue.Enqueue((0, 0));
        minRollDices[0] = 0;

        while (queue.Count > 0)
        {
            var (index, countRollDices) = queue.Dequeue();
            var nextCountRollDices = countRollDices + 1;
            if (minRollDices[index] == countRollDices)
                for (var i = 1; i <= 6; i++)
                {
                    var nextIndex = index + i;
                    if (nextIndex < board.Length)
                    {
                        if (board[nextIndex] >= 0)
                            nextIndex = board[nextIndex];

                        if (board[nextIndex] != -2 &&
                            (minRollDices[nextIndex] == -1 || minRollDices[nextIndex] > nextCountRollDices))
                        {
                            minRollDices[nextIndex] = nextCountRollDices;
                            queue.Enqueue((nextIndex, nextCountRollDices));
                        }
                    }
                }
        }

        return minRollDices[^1];
    }

    private void SetShortPath(int[] board, int index)
    {
        if (board[index] == -1 || board[index] == -2)
            return;

        var nextIndex = index;
        for (var i = 0;
             i < board.Length && board[nextIndex] != -1 && board[nextIndex] != -2 && board[nextIndex] != index;
             i++, nextIndex = board[nextIndex]) ;

        if (board[nextIndex] == -1)
        {
            var neighbourIndex = board[index];
            while (board[neighbourIndex] != -1)
            {
                board[index] = nextIndex;
                index = neighbourIndex;
                neighbourIndex = board[index];
            }
        }

        if (board[nextIndex] == -2)
        {
            var neighbourIndex = board[index];
            while (board[neighbourIndex] != -2)
            {
                board[index] = -2;
                index = neighbourIndex;
                neighbourIndex = board[index];
            }
        }
    }
}