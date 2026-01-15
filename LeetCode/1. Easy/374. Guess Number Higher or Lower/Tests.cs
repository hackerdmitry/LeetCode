using NUnit.Framework;

namespace LeetCode._1._Easy._374._Guess_Number_Higher_or_Lower;

[TestFixture(TestName = "374. Guess Number Higher or Lower")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(2126753390, 1702766719, 1702766719)]
    [TestCase(2, 2, 2)]
    [TestCase(10, 6, 6)]
    [TestCase(1, 1, 1)]
    [TestCase(2, 1, 1)]
    public void Test(int input1, int input2, int output)
    {
        var solution = new Solution();
        solution.Pick = input2;
        var actual = solution.GuessNumber(input1);
        Assert.AreEqual(output, actual);
    }
}
