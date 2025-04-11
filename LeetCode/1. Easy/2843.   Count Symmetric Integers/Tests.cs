using NUnit.Framework;

namespace LeetCode._1._Easy._2843.___Count_Symmetric_Integers;

[TestFixture(TestName = "2843. Count Symmetric Integers")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(1200, 1230, 4)]
    [TestCase(1, 100, 9)]
    public void Test(int input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.CountSymmetricIntegers(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
