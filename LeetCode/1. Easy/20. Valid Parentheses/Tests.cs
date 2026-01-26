using NUnit.Framework;

namespace LeetCode._1._Easy._20._Valid_Parentheses;

[TestFixture(TestName = "20. Valid Parentheses")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("()", true)]
    [TestCase("()[]{}", true)]
    [TestCase("(]", false)]
    [TestCase("([])", true)]
    [TestCase("([)]", false)]
    public void Test(string input, bool output)
    {
        var solution = new Solution();
        var actual = solution.IsValid(input);
        Assert.AreEqual(output, actual);
    }
}
