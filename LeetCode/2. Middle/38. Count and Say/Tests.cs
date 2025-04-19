using NUnit.Framework;

namespace LeetCode._2._Middle._38._Count_and_Say;

[TestFixture(TestName = "38. Count and Say")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(4, "1211")]
    [TestCase(1, "1")]
    public void Test(int input, string output)
    {
        var solution = new Solution();
        var actual = solution.CountAndSay(input);
        Assert.AreEqual(output, actual);
    }
}
