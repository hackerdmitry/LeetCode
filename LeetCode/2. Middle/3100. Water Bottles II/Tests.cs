using NUnit.Framework;

namespace LeetCode._2._Middle._3100._Water_Bottles_II;

[TestFixture(TestName = "3100. Water Bottles II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(10, 3, 13)]
    [TestCase(13, 6, 15)]
    public void Test(int input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxBottlesDrunk(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
