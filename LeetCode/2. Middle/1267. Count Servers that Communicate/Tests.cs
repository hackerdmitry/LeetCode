using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1267._Count_Servers_that_Communicate;

[TestFixture(TestName = "1267. Count Servers that Communicate")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[0,0,1,0,1],[0,1,0,1,0],[0,1,1,1,0],[1,0,0,1,1],[0,0,1,1,0]]", 12)]
    [TestCase("[[0,0,0,0],[1,1,1,1],[0,0,0,1],[0,0,1,1],[0,0,0,1]]", 8)]
    [TestCase("[[1,0],[1,1]]", 3)]
    [TestCase("[[1,0,0,1,0],[0,0,0,0,0],[0,0,0,1,0]]", 3)]
    [TestCase("[[1,0],[0,1]]", 0)]
    [TestCase("[[1,1,0,0],[0,0,1,0],[0,0,1,0],[0,0,0,1]]", 4)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.CountServers(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
