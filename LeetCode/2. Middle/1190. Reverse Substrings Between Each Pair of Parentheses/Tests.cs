using NUnit.Framework;

namespace LeetCode._2._Middle._1190._Reverse_Substrings_Between_Each_Pair_of_Parentheses;

[TestFixture(TestName = "1190. Reverse Substrings Between Each Pair of Parentheses")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("(abcd)", "dcba")]
    [TestCase("(u(love)i)", "iloveu")]
    [TestCase("(ed(et(oc))el)", "leetcode")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.ReverseParentheses(input);
        Assert.AreEqual(output, actual);
    }
}
