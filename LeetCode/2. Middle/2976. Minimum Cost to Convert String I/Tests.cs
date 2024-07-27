using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2976._Minimum_Cost_to_Convert_String_I;

[TestFixture(TestName = "2976. Minimum Cost to Convert String I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("abcd", "acbe", new[]{'a','b','c','c','e','d'}, new[]{'b','c','b','e','b','e'}, "[2,5,5,1,2,20]", 28)]
    [TestCase("aaaa", "bbbb", new[]{'a','c'}, new[]{'c','b'}, "[1,2]", 12)]
    [TestCase("abcd", "abce", new[]{'a'}, new[]{'e'}, "[10000]", -1)]
    public void Test(string input1, string input2, char[] input3, char[] input4, string input5, long output)
    {
        var solution = new Solution();
        var actual = solution.MinimumCost(input1, input2, input3, input4, input5.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
