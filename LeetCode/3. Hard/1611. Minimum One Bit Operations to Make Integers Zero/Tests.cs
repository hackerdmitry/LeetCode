using NUnit.Framework;

namespace LeetCode._3._Hard._1611._Minimum_One_Bit_Operations_to_Make_Integers_Zero;

[TestFixture(TestName = "1611. Minimum One Bit Operations to Make Integers Zero")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(0, 0)]
    [TestCase(1, 1)]
    [TestCase(3, 2)]
    [TestCase(6, 4)]
    [TestCase(11, 13)]
    [TestCase(15, 10)]
    [TestCase(24, 16)]
    [TestCase(20, 24)]
    [TestCase(90, 108)]
    [TestCase(333, 393)]
    public void Test(int input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinimumOneBitOperations(input);
        Assert.AreEqual(output, actual);
    }
}
