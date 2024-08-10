using System.Collections.Generic;
using System.Linq;

namespace LeetCode._2._Middle._959._Regions_Cut_By_Slashes;

public class Solution
{
    private readonly Dictionary<char, Square> typeOfSquares = new()
    {
        [' '] = new Square(
            new PartSquare(Direction.Up, Direction.Right, Direction.Down, Direction.Left)
        ),
        ['/'] = new Square(
            new PartSquare(Direction.Up, Direction.Left),
            new PartSquare(Direction.Right, Direction.Down)
        ),
        ['\\'] = new Square(
            new PartSquare(Direction.Up, Direction.Right),
            new PartSquare(Direction.Down, Direction.Left)
        ),
    };

    public int RegionsBySlashes(string[] grid)
    {
        var height = grid.Length;
        var width = grid[0].Length;

        var unvisitedSquareParts = new HashSet<Point>();

        var squaresMap = new Square[height, width];
        for (var y = 0; y < height; y++)
            for (var x = 0; x < width; x++)
            {
                var square = typeOfSquares[grid[y][x]];
                squaresMap[y, x] = square;
                for (var i = 0; i < square.Parts.Length; i++)
                    unvisitedSquareParts.Add(new Point(y, x, i));
            }

        var result = 0;
        var queue = new Queue<Point>();
        while (unvisitedSquareParts.Count != 0)
        {
            queue.Enqueue(unvisitedSquareParts.First());

            while (queue.Count > 0)
            {
                var point = queue.Dequeue();
                unvisitedSquareParts.Remove(point);

                var square = squaresMap[point.Y, point.X];
                var partSquare = square.Parts[point.PartSquareIndex];

                foreach (var allowDirection in partSquare.AllowDirections)
                {
                    var nextPoint = GetNextPointByDirection(point.Y, point.X, squaresMap, allowDirection);
                    if (nextPoint != null && unvisitedSquareParts.Contains(nextPoint))
                        queue.Enqueue(nextPoint);
                }
            }

            result++;
        }

        return result;
    }

    private Point GetNextPointByDirection(int y, int x, Square[,] squaresMap, Direction direction)
    {
        var nextY = direction switch
        {
            Direction.Up => y - 1,
            Direction.Down => y + 1,
            _ => y,
        };
        var nextX = direction switch
        {
            Direction.Left => x - 1,
            Direction.Right => x + 1,
            _ => x,
        };

        if (nextY < 0 || nextY >= squaresMap.GetLength(0) ||
            nextX < 0 || nextX >= squaresMap.GetLength(1))
            return null;

        var nextSquare = squaresMap[nextY, nextX];
        var nextSquarePart = nextSquare.GetPartFromDirection(GetOppositeDirection(direction));
        return new Point(nextY, nextX, nextSquarePart.Index);
    }

    private Direction GetOppositeDirection(Direction direction) =>
        direction switch
        {
            Direction.Up => Direction.Down,
            Direction.Right => Direction.Left,
            Direction.Down => Direction.Up,
            Direction.Left => Direction.Right,
        };

    record Point(int Y, int X, int PartSquareIndex);

    enum Direction
    {
        Up,
        Right,
        Down,
        Left,
    }

    class Square
    {
        public PartSquare[] Parts { get; set; }

        public Square(params PartSquare[] parts)
        {
            Parts = parts;
        }

        public (PartSquare PartSquare, int Index) GetPartFromDirection(Direction direction)
        {
            return Parts.Select((x, i) => (x, i)).First(x => x.x.AllowDirections.Contains(direction));
        }
    }

    class PartSquare
    {
        public Direction[] AllowDirections { get; set; }

        public PartSquare(params Direction[] allowDirections)
        {
            AllowDirections = allowDirections;
        }
    }
}