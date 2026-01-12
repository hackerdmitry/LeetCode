using LeetCode.__Additional;

namespace LeetCode._2._Middle._236._Lowest_Common_Ancestor_of_a_Binary_Tree;

public class Solution
{
    public TreeNode LowestCommonAncestor(TreeNode node, TreeNode p, TreeNode q)
    {
        if (node == p || node == q)
            return node;

        var left = node.left != null ? LowestCommonAncestor(node.left, p, q) : null;
        var right = node.right != null ? LowestCommonAncestor(node.right, p, q) : null;

        if (left != null && right != null)
            return node;

        if (left == null ^ right == null)
            return left ?? right;

        return null;
    }
}
