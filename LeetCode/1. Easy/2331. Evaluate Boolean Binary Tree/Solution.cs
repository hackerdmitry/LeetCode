using LeetCode.__Additional;

namespace LeetCode._1._Easy._2331._Evaluate_Boolean_Binary_Tree;

public class Solution
{
    public bool EvaluateTree(TreeNode root) =>
        root.val switch
        {
            0 => false,
            1 => true,
            2 => EvaluateTree(root.left) || EvaluateTree(root.right),
            3 => EvaluateTree(root.left) && EvaluateTree(root.right),
        };
}