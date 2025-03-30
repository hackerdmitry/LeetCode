using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1395._Count_Number_of_Teams;

[TestFixture(TestName = "1395. Count Number of Teams")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,4,5]", 10)]
    [TestCase("[2,5,3,4,1]", 3)]
    [TestCase("[2,1,3]", 0)]
    [TestCase("[1,2,3,4]", 4)]
    [TestCase("[2,4,1,3,5,6,7]", 22)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.NumTeams(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
