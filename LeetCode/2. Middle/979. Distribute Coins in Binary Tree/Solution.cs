using System;
using LeetCode.__Additional;

namespace LeetCode._2._Middle._979._Distribute_Coins_in_Binary_Tree;

public class Solution
{
    private int moves;

    public int DistributeCoins(TreeNode root)
    {
        GetVal(root);
        return moves;
    }

    private int GetVal(TreeNode node)
    {
        if (node.left != null)
        {
            var leftVal = GetVal(node.left);
            moves += Math.Abs(leftVal);
            node.val += leftVal;
        }

        if (node.right != null)
        {
            var rightVal = GetVal(node.right);
            moves += Math.Abs(rightVal);
            node.val += rightVal;
        }

        return node.val - 1;
    }
}