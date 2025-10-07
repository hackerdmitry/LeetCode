using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1488._Avoid_Flood_in_The_City;

[TestFixture(TestName = "1488. Avoid Flood in The City")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,4]", "[-1,-1,-1,-1]")]
    [TestCase("[1,2,0,0,2,1]", "[-1,-1,1,2,-1,-1]")]
    [TestCase("[1,2,0,1,2]", "[]")]
    [TestCase("[69,0,0,0,69]", "[-1,1,1,69,-1]")]
    [TestCase("[1,0,2,0,2,1]", "[-1,1,-1,2,-1,-1]")]
    [TestCase("[1,0,0,1,1]", "[]")]
    [TestCase("[1,0,1,0,1]", "[-1,1,-1,1,-1]")]
    [TestCase("[1,0,2,3,0,1,2]", "[-1,1,-1,-1,2,-1,-1]")]
    [TestCase("[1,0,2,3,0,2,1]", "[-1,1,-1,-1,2,-1,-1]")]
    [TestCase("[1,3,0,2,3,0,0,1,2]", "[-1,-1,3,-1,-1,1,2,-1,-1]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.AvoidFlood(input.ParseIntArray());
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
