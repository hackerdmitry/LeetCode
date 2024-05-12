using System.Linq;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._22._Generate_Parentheses;

[TestFixture(TestName = "22. Generate Parentheses")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(3, "[\"((()))\",\"(()())\",\"(())()\",\"()(())\",\"()()()\"]")]
    [TestCase(1, "[\"()\"]")]
    public void Test(int input, string output)
    {
        var solution = new Solution();
        var actual = solution.GenerateParenthesis(input);
        var expected = output.ParseStringArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected.OrderBy(x => x), actual.OrderBy(x => x));
    }
}