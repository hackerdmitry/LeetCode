using NUnit.Framework;

namespace LeetCode._1._Easy._2582._Pass_the_Pillow;

[TestFixture(TestName = "2582. Pass the Pillow")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(4, 5, 2)]
    [TestCase(3, 2, 3)]
    public void Test(int input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.PassThePillow(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
