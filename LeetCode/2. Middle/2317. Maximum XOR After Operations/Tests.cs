using NUnit.Framework;

namespace LeetCode._2._Middle._2317._Maximum_XOR_After_Operations;

[TestFixture(TestName = "2317. Maximum XOR After Operations")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[]{3,2,4,6}, 7)]
    [TestCase(new[]{1,2,3,9,2}, 11)]
    public void Test(int[] input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaximumXOR(input);
        Assert.AreEqual(output, actual);
    }
}
