using System.Collections.Generic;
using System.Linq;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._2699._Modify_Graph_Edge_Weights;

[TestFixture(TestName = "2699. Modify Graph Edge Weights")]
public class Tests
{
    private const int maxValue = 2_000_000_000;

    [Timeout(1000)]
    [TestCase(10, "[[7,0,68],[1,2,61],[2,9,16],[4,7,95],[7,6,-1],[6,5,73],[8,5,42],[5,3,21],[9,3,13],[5,1,-1],[8,3,78],[5,7,-1],[6,9,38],[0,8,26],[0,6,-1],[4,8,68],[9,5,52],[8,2,90],[7,8,37]]", 0, 1, 112, "[[7,0,68],[1,2,61],[2,9,16],[4,7,95],[7,6,1000000005],[6,5,73],[8,5,42],[5,3,21],[9,3,13],[5,1,54],[8,3,78],[5,7,1000000005],[6,9,38],[0,8,26],[0,6,119],[4,8,68],[9,5,52],[8,2,90],[7,8,37]]")]
    [TestCase(4, "[[3,0,-1],[1,2,-1],[2,3,-1],[1,3,9],[2,0,5]]", 0, 1, 7, "[[3,0,5],[1,2,2],[2,3,1000000005],[1,3,9],[2,0,5]]")]
    [TestCase(5, "[[1,3,10],[4,2,-1],[0,3,7],[4,0,7],[3,2,-1],[1,4,5],[2,0,8],[1,0,3],[1,2,5]]", 3, 4, 11, "[[1,3,10],[4,2,1],[0,3,7],[4,0,7],[3,2,10],[1,4,5],[2,0,8],[1,0,3],[1,2,5]]")]
    [TestCase(5, "[[4,1,-1],[2,0,-1],[0,3,-1],[4,3,-1]]", 0, 1, 5, "[[4,1,1],[2,0,1],[0,3,3],[4,3,1]]")]
    [TestCase(3, "[[0,1,-1],[0,2,5]]", 0, 2, 6, "[]")]
    [TestCase(4, "[[1,0,4],[1,2,3],[2,3,5],[0,3,-1]]", 0, 2, 6, "[[1,0,4],[1,2,3],[2,3,5],[0,3,1]]")]
    [TestCase(4, "[[0,1,-1],[2,0,2],[3,2,6],[2,1,10],[3,0,-1]]", 1, 3, 12, "[[0,1,11],[2,0,2],[3,2,6],[2,1,10],[3,0,1]]")]
    public void Test(int input1, string input2, int input3, int input4, int input5, string output)
    {
        var solution = new Solution();
        var actual = solution.ModifiedGraphEdges(input1, input2.ParseIntArray2d(), input3, input4, input5);
        CheckResult(input3, input4, input5, actual, output.ParseIntArray2d());
    }

    private void CheckResult(int start, int end, int target, int[][] actual, int[][] expected)
    {
        if (expected.Length == 0)
        {
            Assert.AreEqual(expected, actual);
            return;
        }

        var neighbours = actual
            .SelectMany(x => new[]
            {
                (From: x[0], (To: x[1], Weight: x[2])),
                (From: x[1], (To: x[0], Weight: x[2])),
            })
            .GroupBy(x => x.From)
            .ToDictionary(x => x.Key, x => x.Select(x => x.Item2));

        var bst = new Dictionary<int, long>();
        var queue = new Queue<(int City, long Distance)>();
        bst[start] = 0;
        queue.Enqueue((start, 0));

        while (queue.Count > 0)
        {
            var (city, distance) = queue.Dequeue();
            if (neighbours.ContainsKey(city))
                foreach (var (to, weight) in neighbours[city])
                    if (!bst.ContainsKey(to) || bst[to] > weight + distance)
                    {
                        bst[to] = weight + distance;
                        queue.Enqueue((to, weight + distance));
                    }
        }

        Assert.True(bst.ContainsKey(end));
        Assert.AreEqual(target, bst[end]);
    }
}