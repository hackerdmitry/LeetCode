using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1014._Best_Sightseeing_Pair;

[TestFixture(TestName = "1014. Best Sightseeing Pair")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[8,1,5,2,6]", 11)]
    [TestCase("[1,2]", 2)]
    [TestCase("[3,3,3,1,1,1,4,1,1,1,3,3,3]", 5)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxScoreSightseeingPair(input.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
