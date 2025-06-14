using NUnit.Framework;

namespace LeetCode._1._Easy._2566._Maximum_Difference_by_Remapping_a_Digit;

[TestFixture(TestName = "2566. Maximum Difference by Remapping a Digit")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(11891, 99009)]
    [TestCase(90, 99)]
    [TestCase(99, 99)]
    public void Test(int input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinMaxDifference(input);
        Assert.AreEqual(output, actual);
    }
}