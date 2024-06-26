using System.Collections.Generic;
using LeetCode.__Additional;

namespace LeetCode._2._Middle._1382._Balance_a_Binary_Search_Tree;

public class Solution
{
    public TreeNode BalanceBST(TreeNode root)
    {
        var list = new List<int>(10_000);

        var toReturn = new Stack<TreeNode>();
        while (root != null)
        {
            toReturn.Push(root);
            root = root.left;
        }

        while (toReturn.Count > 0)
        {
            var node = toReturn.Pop();
            list.Add(node.val);

            node = node.right;
            while (node != null)
            {
                toReturn.Push(node);
                node = node.left;
            }
        }

        return GetTreeNode(list, 0, list.Count - 1);
    }

    private TreeNode GetTreeNode(List<int> list, int leftIndex, int rightIndex)
    {
        var index = (leftIndex + rightIndex) / 2;
        var node = new TreeNode(list[index]);
        if (leftIndex <= index - 1)
            node.left = GetTreeNode(list, leftIndex, index - 1);
        if (index + 1 <= rightIndex)
            node.right = GetTreeNode(list, index + 1, rightIndex);
        return node;
    }
}
