using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._17._Letter_Combinations_of_a_Phone_Number;

[TestFixture(TestName = "17. Letter Combinations of a Phone Number")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("23", "[\"ad\",\"ae\",\"af\",\"bd\",\"be\",\"bf\",\"cd\",\"ce\",\"cf\"]")]
    [TestCase("", "[]")]
    [TestCase("2", "[\"a\",\"b\",\"c\"]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.LetterCombinations(input);
        Assert.AreEqual(output.ParseStringArray(), actual);
    }
}