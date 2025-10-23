using NUnit.Framework;

namespace LeetCode._1._Easy._3461._Check_If_Digits_Are_Equal_in_String_After_Operations_I;

[TestFixture(TestName = "3461. Check If Digits Are Equal in String After Operations I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("3902", true)]
    [TestCase("34789", false)]
    public void Test(string input, bool output)
    {
        var solution = new Solution();
        var actual = solution.HasSameDigits(input);
        Assert.AreEqual(output, actual);
    }
}
