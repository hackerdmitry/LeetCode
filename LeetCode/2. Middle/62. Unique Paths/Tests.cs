using NUnit.Framework;

namespace LeetCode._2._Middle._62._Unique_Paths;

[TestFixture(TestName = "62. Unique Paths")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(3, 7, 28)]
    [TestCase(3, 2, 3)]
    public void Test(int input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.UniquePaths(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
