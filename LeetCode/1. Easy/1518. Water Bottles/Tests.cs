using NUnit.Framework;

namespace LeetCode._1._Easy._1518._Water_Bottles;

[TestFixture(TestName = "1518. Water Bottles")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(9, 3, 13)]
    [TestCase(15, 4, 19)]
    public void Test(int input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.NumWaterBottles(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
