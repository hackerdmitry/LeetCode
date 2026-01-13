using LeetCode.__Additional;

namespace LeetCode._2._Middle._450._Delete_Node_in_a_BST;

public class Solution
{
    public TreeNode DeleteNode(TreeNode root, int key)
    {
        var node = root;
        var parent = (TreeNode) null;
        while (node != null)
        {
            if (node.val == key)
                break;

            parent = node;
            node = key < node.val ? node.left : node.right;
        }

        if (node == null)
            return root;

        if (node.left == null && node.right == null)
        {
            if (parent == null)
                return null;
            if (parent.left == node)
                parent.left = null;
            else
                parent.right = null;
            return root;
        }

        if (node.left == null ^ node.right == null)
        {
            var child = node.left ?? node.right;
            if (parent == null)
                return child;
            if (parent.left == node)
                parent.left = child;
            else
                parent.right = child;
            return root;
        }

        var nextNode = node.right!;

        if (nextNode.left == null)
        {
            if (parent == null)
                root = nextNode;
            else if (parent.left == node)
                parent.left = nextNode;
            else
                parent.right = nextNode;

            nextNode.left = node.left;
        }
        else
        {
            while (nextNode.left != null)
            {
                parent = nextNode;
                nextNode = nextNode.left;
            }

            parent.left = nextNode.right;
            node.val = nextNode.val;
        }

        return root;
    }
}