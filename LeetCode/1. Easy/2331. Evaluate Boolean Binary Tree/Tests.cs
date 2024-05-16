using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._2331._Evaluate_Boolean_Binary_Tree;

[TestFixture(TestName = "2331. Evaluate Boolean Binary Tree")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,1,3,null,null,0,1]", true)]
    [TestCase("[0]", false)]
    public void Test(string input, bool output)
    {
        var solution = new Solution();
        var actual = solution.EvaluateTree(input.ParseNullIntArray());
        Assert.AreEqual(output, actual);
    }
}