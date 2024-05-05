using System.Collections.Generic;
using LeetCode.__Additional;

namespace LeetCode._1._Easy._94._Binary_Tree_Inorder_Traversal;

public class Solution
{
    public IList<int> InorderTraversal(TreeNode root)
    {
        var result = new List<int>();
        if (root == null)
            return result;

        var stack = new Stack<(TreeNode, int)>();
        stack.Push((root, 1));

        while (stack.Count > 0)
        {
            var (node, state) = stack.Pop();

            if (state == 1)
            {
                state++;
                if (node.left != null)
                {
                    stack.Push((node, 2));
                    stack.Push((node.left, 1));
                    continue;
                }
            }

            if (state == 2)
            {
                state++;
                result.Add(node.val);
            }

            if (state == 3 && node.right != null)
                stack.Push((node.right, 1));
        }

        return result;
    }
}