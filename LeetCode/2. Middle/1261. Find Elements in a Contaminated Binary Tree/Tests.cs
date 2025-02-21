using LeetCode.__Additional;
using NUnit.Framework;

namespace LeetCode._2._Middle._1261._Find_Elements_in_a_Contaminated_Binary_Tree;

[Timeout(1000)]
[TestFixture(TestName = "1261. Find Elements in a Contaminated Binary Tree")]
public class Tests
{
    [Test]
    public void Test1()
    {
        var solution = new FindElements(TreeNode.CreateFromArray(new int?[] {-1, null, -1}));
        Assert.IsFalse(solution.Find(1));
        Assert.IsTrue(solution.Find(2));
    }

    [Test]
    public void Test2()
    {
        var solution = new FindElements(TreeNode.CreateFromArray(new int?[] {-1, -1, -1, -1, -1}));
        Assert.IsTrue(solution.Find(1));
        Assert.IsTrue(solution.Find(3));
        Assert.IsFalse(solution.Find(5));
    }

    [Test]
    public void Test3()
    {
        var solution = new FindElements(TreeNode.CreateFromArray(new int?[] {-1, null, -1, -1, null, -1}));
        Assert.IsTrue(solution.Find(2));
        Assert.IsFalse(solution.Find(3));
        Assert.IsFalse(solution.Find(4));
        Assert.IsTrue(solution.Find(5));
    }
}