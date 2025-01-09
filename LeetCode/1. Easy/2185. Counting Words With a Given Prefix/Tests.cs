using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._2185._Counting_Words_With_a_Given_Prefix;

[TestFixture(TestName = "2185. Counting Words With a Given Prefix")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[\"pay\",\"attention\",\"practice\",\"attend\"]", "at", 2)]
    [TestCase("[\"leetcode\",\"win\",\"loops\",\"success\"]", "code", 0)]
    public void Test(string input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.PrefixCount(input1.ParseStringArray(), input2);
        Assert.AreEqual(output, actual);
    }
}
