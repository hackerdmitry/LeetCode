using System.Collections.Generic;
using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._199._Binary_Tree_Right_Side_View;

[TestFixture(TestName = "199. Binary Tree Right Side View")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,null,5,null,4]", "[1,3,4]")]
    [TestCase("[1,2,3,4,null,null,null,5]", "[1,3,4,5]")]
    [TestCase("[1,null,3]", "[1,3]")]
    [TestCase("[]", "[]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.RightSideView(input.ParseNullIntArray());
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
