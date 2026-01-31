using NUnit.Framework;

namespace LeetCode._1._Easy._3823._Reverse_Letters_Then_Special_Characters_in_a_String;

[TestFixture(TestName = "3823. Reverse Letters Then Special Characters in a String")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(")ebc#da@f(", "(fad@cb#e)")]
    [TestCase("z", "z")]
    [TestCase("!@#$%^&*()", ")(*&^%$#@!")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.ReverseByType(input);
        Assert.AreEqual(output, actual);
    }
}
