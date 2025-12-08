using NUnit.Framework;

namespace LeetCode._1._Easy._1925._Count_Square_Sum_Triples;

[TestFixture(TestName = "1925. Count Square Sum Triples")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(5, 2)]
    [TestCase(10, 4)]
    public void Test(int input, int output)
    {
        var solution = new Solution();
        var actual = solution.CountTriples(input);
        Assert.AreEqual(output, actual);
    }
}
