using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._222._Count_Complete_Tree_Nodes;

[TestFixture(TestName = "222. Count Complete Tree Nodes")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,4,5,6]", 6)]
    [TestCase("[]", 0)]
    [TestCase("[1]", 1)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.CountNodes(input.ParseNullIntArray());
        Assert.AreEqual(output, actual);
    }
}