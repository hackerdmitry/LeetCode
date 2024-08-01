using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._2678._Number_of_Senior_Citizens;

[TestFixture(TestName = "2678. Number of Senior Citizens")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[\"7868190130M7522\",\"5303914400F9211\",\"9273338290F4010\"]", 2)]
    [TestCase("[\"1313579440F2036\",\"2921522980M5644\"]", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.CountSeniors(input.ParseStringArray());
        Assert.AreEqual(output, actual);
    }
}