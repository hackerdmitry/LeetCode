using System.Collections.Generic;

namespace LeetCode.__Additional;

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    public static TreeNode CreateFromArray(int?[] input)
    {
        var index = 0;
        var treeRoot = input.Length > 0 && input[index].HasValue ? new TreeNode(input[index++].Value) : null;
        if (treeRoot != null)
        {
            var queue = new Queue<TreeNode>();
            queue.Enqueue(treeRoot);
            while (queue.Count > 0 && input.Length > index)
            {
                var left = input.Length > index ? input[index++] : null;
                var right = input.Length > index ? input[index++] : null;

                var node = queue.Dequeue();
                if (left != null)
                {
                    node.left = new TreeNode(left.Value);
                    queue.Enqueue(node.left);
                }

                if (right != null)
                {
                    node.right = new TreeNode(right.Value);
                    queue.Enqueue(node.right);
                }
            }
        }

        return treeRoot;
    }

    public override string ToString()
    {
        return val.ToString();
    }

    public static implicit operator TreeNode(int?[] array)
    {
        return CreateFromArray(array);
    }
}