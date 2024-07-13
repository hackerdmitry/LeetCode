using System.Collections.Generic;
using System.Linq;

namespace LeetCode._3._Hard._2751._Robot_Collisions;

public class Solution
{
    public IList<int> SurvivedRobotsHealths(int[] positions, int[] healths, string directions)
    {
        var robots = new Robot[positions.Length];

        for (var i = 0; i < robots.Length; i++)
            robots[i] = new Robot(positions[i], healths[i], ToDirection(directions[i]));

        var positionToHealth = new Dictionary<int, int>();
        var leftRobotsStack = new Stack<Robot>();

        foreach (var robot in robots.OrderBy(x => x.Position))
            switch (robot.Direction)
            {
                case Direction.Right:
                    leftRobotsStack.Push(robot);
                    break;
                case Direction.Left:
                    if (leftRobotsStack.Count > 0)
                    {
                        var winRobot = Battle(leftRobotsStack.Pop(), robot);
                        while (true)
                        {
                            if (winRobot == null)
                                break;

                            if (winRobot.Direction == Direction.Right)
                            {
                                leftRobotsStack.Push(winRobot);
                                break;
                            }

                            if (leftRobotsStack.Count == 0)
                            {
                                positionToHealth[winRobot.Position] = winRobot.Health;
                                break;
                            }

                            winRobot = Battle(leftRobotsStack.Pop(), robot);
                        }
                    }
                    else
                        positionToHealth[robot.Position] = robot.Health;

                    break;
            }

        while (leftRobotsStack.Count > 0)
        {
            var robot = leftRobotsStack.Pop();
            positionToHealth[robot.Position] = robot.Health;
        }

        return positions
            .Where(x => positionToHealth.ContainsKey(x))
            .Select(x => positionToHealth[x])
            .ToArray();
    }

    private Robot Battle(Robot leftRobot, Robot rightRobot)
    {
        if (leftRobot.Health == rightRobot.Health)
            return null;

        var winRobot = leftRobot.Health < rightRobot.Health ? rightRobot : leftRobot;
        winRobot.Health--;

        return winRobot.Health == 0 ? null : winRobot;
    }

    private Direction ToDirection(char direction) =>
        direction switch
        {
            'L' => Direction.Left,
            'R' => Direction.Right,
        };

    private class Robot
    {
        public int Position { get; set; }
        public int Health { get; set; }
        public Direction Direction { get; set; }

        public Robot(int position, int health, Direction direction)
        {
            Position = position;
            Health = health;
            Direction = direction;
        }
    }

    private enum Direction
    {
        Left,
        Right
    }
}