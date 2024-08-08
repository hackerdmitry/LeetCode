using System.Collections.Generic;

namespace LeetCode._2._Middle._885._Spiral_Matrix_III;

public class Solution
{
    private static readonly Dictionary<Direction, Direction> nextDirections = new()
    {
        [Direction.Right] = Direction.Down,
        [Direction.Down] = Direction.Left,
        [Direction.Left] = Direction.Up,
        [Direction.Up] = Direction.Right,
    };

    public int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart)
    {
        var leftCells = rows * cols;
        var result = new int[leftCells][];
        for (var i = 0; i < leftCells; i++)
            result[i] = new int[2];

        var num = 0;

        var direction = Direction.Right;
        var startLeftMoveToChangeDirection = 1;
        var leftMoveToChangeDirection = startLeftMoveToChangeDirection;

        var y = rStart;
        var x = cStart;
        while (leftCells > 0)
        {
            if (InMatrix(x, y, rows, cols))
            {
                result[num][0] = y;
                result[num++][1] = x;
                leftCells--;
            }

            y = ChangeVertical(y, direction);
            x = ChangeHorizontal(x, direction);

            leftMoveToChangeDirection--;
            if (leftMoveToChangeDirection <= 0)
            {
                direction = NextDirection(direction);
                if (direction is Direction.Left or Direction.Right)
                    startLeftMoveToChangeDirection++;
                leftMoveToChangeDirection = startLeftMoveToChangeDirection;
            }
        }

        return result;
    }

    private Direction NextDirection(Direction direction) =>
        nextDirections[direction];

    private bool InMatrix(int x, int y, int rows, int cols) =>
        x >= 0 && x < cols &&
        y >= 0 && y < rows;

    private int ChangeVertical(int currVertical, Direction direction) =>
        direction switch
        {
            Direction.Up => currVertical - 1,
            Direction.Down => currVertical + 1,
            _ => currVertical,
        };

    private int ChangeHorizontal(int currHorizontal, Direction direction) =>
        direction switch
        {
            Direction.Right => currHorizontal + 1,
            Direction.Left => currHorizontal - 1,
            _ => currHorizontal,
        };

    enum Direction
    {
        Right,
        Down,
        Left,
        Up,
    }
}
