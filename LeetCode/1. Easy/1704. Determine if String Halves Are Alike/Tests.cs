using NUnit.Framework;

namespace LeetCode._1._Easy._1704._Determine_if_String_Halves_Are_Alike;

[TestFixture(TestName = "1704. Determine if String Halves Are Alike")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("book", true)]
    [TestCase("textbook", false)]
    public void Test(string input, bool output)
    {
        var solution = new Solution();
        var actual = solution.HalvesAreAlike(input);
        Assert.AreEqual(output, actual);
    }
}
