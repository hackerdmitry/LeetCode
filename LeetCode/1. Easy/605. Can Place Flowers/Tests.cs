using NUnit.Framework;

namespace LeetCode._1._Easy._605._Can_Place_Flowers;

[TestFixture(TestName = "605. Can Place Flowers")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{1,0,0,0,1}, 1, true)]
    [TestCase(new[]{1,0,0,0,1}, 2, false)]
    [TestCase(new[]{0,0,1,0,1}, 1, true)]
    [TestCase(new[]{1,0,0,0,0,1}, 2, false)]
    [TestCase(new[]{0}, 1, true)]
    public void Test(int[] input1, int input2, bool output)
    {
        var solution = new Solution();
        var actual = solution.CanPlaceFlowers(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
