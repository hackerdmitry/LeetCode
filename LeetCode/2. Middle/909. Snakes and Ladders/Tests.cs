using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._909._Snakes_and_Ladders;

[TestFixture(TestName = "909. Snakes and Ladders")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[-1,-1,30,14,15,-1],[23,9,-1,-1,-1,9],[12,5,7,24,-1,30],[10,-1,-1,-1,25,17],[32,-1,28,-1,-1,32],[-1,-1,23,-1,13,19]]", 2)]
    [TestCase("[[1,1,-1],[1,1,1],[-1,1,1]]", -1)]
    [TestCase("[[-1,4,-1],[6,2,6],[-1,3,-1]]", 2)]
    [TestCase("[[-1,-1,-1,-1,-1,-1],[-1,-1,-1,-1,-1,-1],[-1,-1,-1,-1,-1,-1],[-1,35,-1,-1,13,-1],[36,-1,-1,-1,-1,-1],[-1,15,-1,-1,-1,-1]]", 2)]
    [TestCase("[[-1,-1,-1,-1,-1,-1],[-1,-1,-1,-1,-1,-1],[-1,-1,-1,-1,-1,-1],[-1,35,-1,-1,13,-1],[-1,-1,-1,-1,-1,-1],[-1,15,-1,-1,-1,-1]]", 4)]
    [TestCase("[[-1,-1],[-1,3]]", 1)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.SnakesAndLadders(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
