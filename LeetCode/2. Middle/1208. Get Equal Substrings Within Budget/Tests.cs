using NUnit.Framework;

namespace LeetCode._2._Middle._1208._Get_Equal_Substrings_Within_Budget;

[TestFixture(TestName = "1208. Get Equal Substrings Within Budget")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("abcd", "bcdf", 3, 3)]
    [TestCase("abcd", "cdef", 3, 1)]
    [TestCase("abcd", "acde", 0, 1)]
    public void Test(string input1, string input2, int input3, int output)
    {
        var solution = new Solution();
        var actual = solution.EqualSubstring(input1, input2, input3);
        Assert.AreEqual(output, actual);
    }
}