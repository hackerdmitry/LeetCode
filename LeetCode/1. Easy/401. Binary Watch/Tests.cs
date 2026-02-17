using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._401._Binary_Watch;

[TestFixture(TestName = "401. Binary Watch")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(1, "[\"0:01\",\"0:02\",\"0:04\",\"0:08\",\"0:16\",\"0:32\",\"1:00\",\"2:00\",\"4:00\",\"8:00\"]")]
    [TestCase(9, "[]")]
    public void Test(int input, string output)
    {
        var solution = new Solution();
        var actual = solution.ReadBinaryWatch(input);
        Assert.AreEqual(output.ParseStringArray(), actual);
    }
}
