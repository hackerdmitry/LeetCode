using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2109._Adding_Spaces_to_a_String;

[TestFixture(TestName = "2109. Adding Spaces to a String")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("LeetcodeHelpsMeLearn", "[8,13,15]", "Leetcode Helps Me Learn")]
    [TestCase("icodeinpython", "[1,5,7,9]", "i code in py thon")]
    [TestCase("spacing", "[0,1,2,3,4,5,6]", " s p a c i n g")]
    public void Test(string input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.AddSpaces(input1, input2.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
