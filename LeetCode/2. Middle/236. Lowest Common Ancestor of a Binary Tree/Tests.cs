using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._236._Lowest_Common_Ancestor_of_a_Binary_Tree;

[TestFixture(TestName = "236. Lowest Common Ancestor of a Binary Tree")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[3,5,1,6,2,0,8,null,null,7,4]", 5, 1, "3")]
    [TestCase("[3,5,1,6,2,0,8,null,null,7,4]", 5, 4, "5")]
    [TestCase("[1,2]", 1, 2, "1")]
    public void Test(string input1, int input2, int input3, string output)
    {
        var solution = new Solution();
        var root = (TreeNode) input1.ParseNullIntArray();
        var actual = solution.LowestCommonAncestor(root, FindNode(root, input2), FindNode(root, input3));
        Assert.AreEqual(output.ParseInt(), actual.val);
    }

    private TreeNode FindNode(TreeNode node, int val)
    {
        if (node == null)
            return null;

        return node.val == val
            ? node
            : FindNode(node.left, val) ?? FindNode(node.right, val);
    }
}
