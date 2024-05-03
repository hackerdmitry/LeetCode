using NUnit.Framework;

namespace LeetCode._2._Middle._165._Compare_Version_Numbers;

[TestFixture(TestName = "165. Compare Version Numbers")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("1.01", "1.001", 0)]
    [TestCase("1.0", "1.0.0", 0)]
    [TestCase("0.1", "1.1", -1)]
    [TestCase("1.0.1", "1", 1)]
    public void Test(string input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.CompareVersion(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
