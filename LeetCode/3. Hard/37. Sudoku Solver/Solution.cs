using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode._3._Hard._37._Sudoku_Solver;

public class Solution
{
    public void SolveSudoku(char[][] board) => new Sudoku(board).Solve();

    class Sudoku
    {
        private char[][] board;
        private int unfilledCells;
        private Cell[][] cells;

        private const int height = 9;
        private const int width = 9;

        public Sudoku(char[][] board)
        {
            this.board = board;
            unfilledCells = width * height;
            cells = new Cell[height][];
            for (var y = 0; y < height; y++)
            {
                cells[y] = new Cell[width];
                for (var x = 0; x < width; x++)
                    cells[y][x] = new Cell(board[y][x] == '.' ? null : board[y][x] - '0');
            }

            SetPossibleValues();
        }

        public bool Solve()
        {
            while (unfilledCells > 0)
                if (!(CrossOutSinglePossibleValues() || CrossOutSingleSquarePossibleValues() || CrossOutSingleHorizontalPossibleValues() || CrossOutSingleVerticalPossibleValues()))
                {
                    var cellWithPossibleValues = (Cell) null;
                    var (cy, cx) = (-1, -1);
                    for (var y = 0; y < height; y++)
                        for (var x = 0; x < width; x++)
                        {
                            var cell = cells[y][x];
                            if (cell.PossibleValues?.Count == 2)
                            {
                                cellWithPossibleValues = cell;
                                (cy, cx) = (y, x);
                                goto next;
                            }
                        }

                    next: ;

                    if (cellWithPossibleValues != null)
                    {
                        var board1 = DuplicateBoard();
                        var board2 = DuplicateBoard();

                        board1[cy][cx] = (char) (cellWithPossibleValues.PossibleValues.First() + '0');
                        board2[cy][cx] = (char) (cellWithPossibleValues.PossibleValues.Last() + '0');

                        if (new Sudoku(board1).Solve())
                            FillBoard(board1);
                        else if (new Sudoku(board2).Solve())
                            FillBoard(board2);
                        else
                            return false;
                        return true;
                    }

                    Console.WriteLine(
                        $"unfilled: {unfilledCells}\n" +
                        string.Join('\n', Enumerable.Range(0, 9).Select(y => string.Join(' ', Enumerable.Range(0, 9).Select(x => cells[y][x].Value.HasValue ? (char) (cells[y][x].Value.Value + '0') : ' ')))));
                    return false;
                }

            FillBoard();
            return true;
        }

        private bool CrossOutSinglePossibleValues()
        {
            var isSuccessful = false;

            for (var y = 0; y < height; y++)
                for (var x = 0; x < width; x++)
                {
                    var cell = cells[y][x];
                    if (cell.PossibleValues is {Count: 1})
                    {
                        CrossOutPossibleValue(y, x, cell.PossibleValues.First());
                        isSuccessful = true;
                    }
                }

            return isSuccessful;
        }

        // TODO (hackerdmitry, 13.05.2024 18:48): debug
        private string GetDetailBoard()
        {
            var cellsToString = new string[height][];
            for (var y = 0; y < height; y++)
            {
                cellsToString[y] = new string[width];
                for (var x = 0; x < width; x++)
                    cellsToString[y][x] = cells[y][x].ToString();
            }

            var detailBoard = new StringBuilder();
            var maxWidths = Enumerable.Range(0, width).Select(x => Enumerable.Range(0, height).Max(y => cellsToString[y][x].Length)).ToArray();
            for (var y = 0; y < height; y++)
            {
                for (var x = 0; x < width; x++)
                {
                    detailBoard.Append(cellsToString[y][x].PadRight(maxWidths[x]));
                    if (x != width - 1)
                        detailBoard.Append((x + 1) % 3 == 0 ? " ‖ " : " | ");
                }

                if ((y + 1) % 3 == 0 && y != height - 1)
                {
                    detailBoard.AppendLine();
                    detailBoard.Append(new string('-', maxWidths.Sum() + width - 1));
                }

                detailBoard.AppendLine();
            }

            return detailBoard.ToString();
        }

        private bool CrossOutSingleSquarePossibleValues()
        {
            var isSuccessful = false;

            for (var sy = 0; sy < height; sy += 3)
                for (var sx = 0; sx < width; sx += 3)
                    isSuccessful |= CrossOutSingleAreaPossibleValues(sy, sy + 3, sx, sx + 3);

            return isSuccessful;
        }

        private bool CrossOutSingleHorizontalPossibleValues()
        {
            var isSuccessful = false;

            for (var y = 0; y < height; y++)
                isSuccessful |= CrossOutSingleAreaPossibleValues(y, y + 1, 0, width);

            return isSuccessful;
        }

        private bool CrossOutSingleVerticalPossibleValues()
        {
            var isSuccessful = false;

            for (var x = 0; x < width; x++)
                isSuccessful |= CrossOutSingleAreaPossibleValues(0, height, x, x + 1);

            return isSuccessful;
        }

        private bool CrossOutSingleAreaPossibleValues(int fromY, int toY, int fromX, int toX)
        {
            var isSuccessful = false;

            for (var value = 1; value <= 9; value++)
            {
                var (fy, fx) = (-1, -1);

                for (var y = fromY; y < toY; y++)
                    for (var x = fromX; x < toX; x++)
                    {
                        var cell = cells[y][x];
                        if (cell.Value.HasValue)
                            if (cell.Value.Value == value)
                                goto nextValue;
                            else
                                continue;
                        if (cell.PossibleValues.Contains(value))
                            if (fy != -1)
                                goto nextValue;
                            else
                                (fy, fx) = (y, x);
                    }

                if (fy != -1)
                {
                    CrossOutPossibleValue(fy, fx, value);
                    isSuccessful = true;
                }

                nextValue: ;
            }

            return isSuccessful;
        }

        private void FillBoard()
        {
            for (var y = 0; y < height; y++)
                for (var x = 0; x < width; x++)
                    board[y][x] = (char) (cells[y][x].Value.Value + '0');
        }

        private void FillBoard(char[][] duplicateBoard)
        {
            for (var y = 0; y < height; y++)
                for (var x = 0; x < width; x++)
                    board[y][x] = duplicateBoard[y][x];
        }

        private void SetPossibleValues()
        {
            for (var y = 0; y < height; y++)
                for (var x = 0; x < width; x++)
                {
                    var cell = cells[y][x];
                    if (cell.Value.HasValue)
                    {
                        unfilledCells--;
                        CrossOutPossibleValue(y, x, cell.Value.Value);
                    }
                }
        }

        private void CrossOutPossibleValue(int y, int x, int value)
        {
            if (!cells[y][x].Value.HasValue)
                unfilledCells--;
            cells[y][x].Value = value;
            cells[y][x].PossibleValues?.Clear();
            CrossOutFromSquare(y / 3, x / 3, value);
            CrossOutFromHorizontal(y, value);
            CrossOutFromVertical(x, value);
        }

        private void CrossOutFromSquare(int sy, int sx, int value)
        {
            for (var y = 0; y < 3; y++)
                for (var x = 0; x < 3; x++)
                    cells[sy * 3 + y][sx * 3 + x].PossibleValues?.Remove(value);
        }

        private void CrossOutFromHorizontal(int y, int value)
        {
            for (var x = 0; x < width; x++)
                cells[y][x].PossibleValues?.Remove(value);
        }

        private void CrossOutFromVertical(int x, int value)
        {
            for (var y = 0; y < height; y++)
                cells[y][x].PossibleValues?.Remove(value);
        }

        private char[][] DuplicateBoard()
        {
            var copyBoard = new char[height][];
            for (var y = 0; y < height; y++)
            {
                copyBoard[y] = new char[width];
                for (var x = 0; x < width; x++)
                    copyBoard[y][x] = board[y][x];
            }

            return copyBoard;
        }
    }

    class Cell
    {
        public int? Value { get; set; }
        public HashSet<int> PossibleValues { get; set; }

        public Cell(int? value)
        {
            Value = value;
            if (!value.HasValue)
                PossibleValues = new HashSet<int> {1, 2, 3, 4, 5, 6, 7, 8, 9};
        }

        public override string ToString()
        {
            return Value.HasValue ? "V=" + Value : $"P{PossibleValues.Count}=[{string.Join(',', PossibleValues)}]";
        }
    }
}