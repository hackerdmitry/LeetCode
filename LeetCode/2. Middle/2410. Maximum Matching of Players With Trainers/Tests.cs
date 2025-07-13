using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2410._Maximum_Matching_of_Players_With_Trainers;

[TestFixture(TestName = "2410. Maximum Matching of Players With Trainers")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[4,7,9]", "[8,2,5,8]", 2)]
    [TestCase("[1,1,1]", "[10]", 1)]
    public void Test(string input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MatchPlayersAndTrainers(input1.ParseIntArray(), input2.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}