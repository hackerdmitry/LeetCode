using NUnit.Framework;

namespace LeetCode._2._Middle._1513._Number_of_Substrings_With_Only_1s;

[TestFixture(TestName = "1513. Number of Substrings With Only 1s")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("0110111", 9)]
    [TestCase("101", 2)]
    [TestCase("111111", 21)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.NumSub(input);
        Assert.AreEqual(output, actual);
    }
}