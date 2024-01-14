using NUnit.Framework;

namespace LeetCode._2._Middle._1657._Determine_if_Two_Strings_Are_Close;

[TestFixture(TestName = "1657. Determine if Two Strings Are Close")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("abc","bca", true)]
    [TestCase("a", "aa", false)]
    [TestCase("cabbba", "abbccc", true)]
    [TestCase("uau", "ssx", false)]
    [TestCase("abbzccca", "babzzczc", true)]
    public void Test(string input1, string input2, bool output)
    {
        var solution = new Solution();
        var actual = solution.CloseStrings(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
