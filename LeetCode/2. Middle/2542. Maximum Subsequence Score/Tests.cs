using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2542._Maximum_Subsequence_Score;

[TestFixture(TestName = "2542. Maximum Subsequence Score")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[10,10,20,20]", "[3,3,2,2]", 2, 80)]
    [TestCase("[1,3,3,2]", "[2,1,3,4]", 3, 12)]
    [TestCase("[4,2,3,1,1]", "[7,5,10,9,6]", 1, 30)]
    public void Test(string input1, string input2, int input3, long output)
    {
        var solution = new Solution();
        var actual = solution.MaxScore(input1.ParseIntArray(), input2.ParseIntArray(), input3);
        Assert.AreEqual(output, actual);
    }
}
