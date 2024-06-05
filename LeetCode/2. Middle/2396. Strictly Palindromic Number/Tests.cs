using NUnit.Framework;

namespace LeetCode._2._Middle._2396._Strictly_Palindromic_Number;

[TestFixture(TestName = "2396. Strictly Palindromic Number")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(9, false)]
    [TestCase(4, false)]
    public void Test(int input, bool output)
    {
        var solution = new Solution();
        var actual = solution.IsStrictlyPalindromic(input);
        Assert.AreEqual(output, actual);
    }
}
