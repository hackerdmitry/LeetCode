using NUnit.Framework;

namespace LeetCode._3._Hard._600._Non_negative_Integers_without_Consecutive_Ones;

[TestFixture(TestName = "600. Non-negative Integers without Consecutive Ones")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(0, 1)]
    [TestCase(1, 2)]
    [TestCase(2, 3)]
    [TestCase(3, 3)]
    [TestCase(4, 4)]
    [TestCase(5, 5)]
    [TestCase(6, 5)]
    [TestCase(7, 5)]
    [TestCase(8, 6)]
    [TestCase(9, 7)]
    [TestCase(10, 8)]
    [TestCase(11, 8)]
    [TestCase(12, 8)]
    [TestCase(13, 8)]
    [TestCase(14, 8)]
    [TestCase(15, 8)]
    [TestCase(16, 9)]
    [TestCase(17, 10)]
    [TestCase(18, 11)]
    [TestCase(19, 11)]
    [TestCase(20, 12)]
    public void Test(int input, int output)
    {
        var solution = new Solution();
        var actual = solution.FindIntegers(input);
        Assert.AreEqual(output, actual);
    }
}
