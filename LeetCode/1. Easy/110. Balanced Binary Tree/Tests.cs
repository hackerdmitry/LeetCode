using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._110._Balanced_Binary_Tree;

[TestFixture(TestName = "110. Balanced Binary Tree")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[3,9,20,null,null,15,7]", true)]
    [TestCase("[1,2,2,3,3,null,null,4,4]", false)]
    [TestCase("[]", true)]
    public void Test(string input, bool output)
    {
        var solution = new Solution();
        var actual = solution.IsBalanced(input.ParseNullIntArray());
        Assert.AreEqual(output, actual);
    }
}
