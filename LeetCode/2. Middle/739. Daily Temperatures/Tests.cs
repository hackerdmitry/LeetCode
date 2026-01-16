using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._739._Daily_Temperatures;

[TestFixture(TestName = "739. Daily Temperatures")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[73,74,75,71,69,72,76,73]", "[1,1,4,2,1,1,0,0]")]
    [TestCase("[30,40,50,60]", "[1,1,1,0]")]
    [TestCase("[30,60,90]", "[1,1,0]")]
    [TestCase("[73,72,75]", "[2,1,0]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.DailyTemperatures(input.ParseIntArray());
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
