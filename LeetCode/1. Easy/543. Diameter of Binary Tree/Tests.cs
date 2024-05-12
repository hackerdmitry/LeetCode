using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._543._Diameter_of_Binary_Tree;

[TestFixture(TestName = "543. Diameter of Binary Tree")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,4,5]", 3)]
    [TestCase("[1,2]", 1)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.DiameterOfBinaryTree(input.ParseNullIntArray());
        Assert.AreEqual(output, actual);
    }
}