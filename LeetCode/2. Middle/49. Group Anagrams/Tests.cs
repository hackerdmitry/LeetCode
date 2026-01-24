using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._49._Group_Anagrams;

[TestFixture(TestName = "49. Group Anagrams")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[\"eat\",\"tea\",\"tan\",\"ate\",\"nat\",\"bat\"]", "[[\"bat\"],[\"nat\",\"tan\"],[\"ate\",\"eat\",\"tea\"]]")]
    [TestCase("[\"\"]", "[[\"\"]]")]
    [TestCase("[\"a\"]", "[[\"a\"]]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.GroupAnagrams(input.ParseStringArray());
        var expected = output.ParseStringArray2d();
        actual.WriteLine("actual");
        expected.WriteLine("expected");
        Assert.AreEqual(expected, actual);
    }
}