using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._735._Asteroid_Collision;

[TestFixture(TestName = "735. Asteroid Collision")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[5,10,-5]", "[5,10]")]
    [TestCase("[8,-8]", "[]")]
    [TestCase("[10,2,-5]", "[10]")]
    [TestCase("[3,5,-6,2,-1,4]", "[-6,2,4]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.AsteroidCollision(input.ParseIntArray());
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
