using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._104._Maximum_Depth_of_Binary_Tree;

[TestFixture(TestName = "104. Maximum Depth of Binary Tree")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[3,9,20,null,null,15,7]", 3)]
    [TestCase("[1,null,2]", 2)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxDepth(input.ParseNullIntArray());
        Assert.AreEqual(output, actual);
    }
}
