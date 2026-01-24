namespace LeetCode._2._Middle._289._Game_of_Life;

public class Solution
{
    private readonly int[] directions = {0, 1, 1, -1, 1, 0, -1, -1, 0};

    public void GameOfLife(int[][] board)
    {
        var n = board.Length;
        var m = board[0].Length;
        var prevLine = new int[m];
        var prevCell = -1;

        for (var y = 0; y < n; y++)
        {
            for (var x = 0; x < m; x++)
            {
                var nextState = GetNextState(board, y, x, n, m, prevLine, prevCell);
                if (x > 0)
                    prevLine[x - 1] = prevCell;
                prevCell = board[y][x];
                board[y][x] = nextState;
            }

            prevLine[^1] = prevCell;
        }
    }

    private int GetNextState(int[][] board, int y, int x, int n, int m, int[] prevLine, int prevCell)
    {
        var countLiveNeighbours = 0;

        for (var i = 0; i < 8; i++)
        {
            var ny = y + directions[i];
            var nx = x + directions[i + 1];
            if (InBound(ny, nx, n, m))
                countLiveNeighbours += directions[i] switch
                {
                    -1 => prevLine[nx],
                    0 when directions[i + 1] == -1 => prevCell,
                    _ => board[ny][nx],
                };
        }

        return (board[y][x] == 1
            ? countLiveNeighbours is 2 or 3
            : countLiveNeighbours == 3)
            ? 1
            : 0;
    }

    private bool InBound(int y, int x, int n, int m) =>
        y >= 0 && y < n && x >= 0 && x < m;
}