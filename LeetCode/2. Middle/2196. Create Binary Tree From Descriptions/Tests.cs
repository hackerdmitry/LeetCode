using System;
using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2196._Create_Binary_Tree_From_Descriptions;

[TestFixture(TestName = "2196. Create Binary Tree From Descriptions")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[20,15,1],[20,17,0],[50,20,1],[50,80,0],[80,19,1]]", "[50,20,80,15,17,19]")]
    [TestCase("[[1,2,1],[2,3,0],[3,4,1]]", "[1,2,null,null,3,4]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.CreateBinaryTree(input.ParseIntArray2d()).ToArray();
        var expected = output.ParseNullIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
