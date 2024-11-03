using NUnit.Framework;

namespace LeetCode._1._Easy._796._Rotate_String;

[TestFixture(TestName = "796. Rotate String")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("abcde", "cdeab", true)]
    [TestCase("abcde", "abced", false)]
    public void Test(string input1, string input2, bool output)
    {
        var solution = new Solution();
        var actual = solution.RotateString(input1, input2);
        Assert.AreEqual(output, actual);
    }
}