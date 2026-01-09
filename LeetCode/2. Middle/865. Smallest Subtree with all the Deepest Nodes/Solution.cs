using System.Collections.Generic;
using System.Linq;
using LeetCode.__Additional;

namespace LeetCode._2._Middle._865._Smallest_Subtree_with_all_the_Deepest_Nodes;

public class Solution
{
    public TreeNode SubtreeWithAllDeepest(TreeNode root)
    {
        var parents = new Dictionary<TreeNode, TreeNode>();
        return FindMinimalSubTreeNode(FindDeepestNodes(root, parents).ToArray(), parents);
    }

    private IEnumerable<TreeNode> FindDeepestNodes(TreeNode root, Dictionary<TreeNode, TreeNode> parents)
    {
        var maxDepth = 1;
        var queue = new Queue<(TreeNode node, int depth)>();

        queue.Enqueue((root, 1));
        while (queue.Count > 0)
        {
            var (node, depth) = queue.Dequeue();
            if (depth > maxDepth)
                maxDepth = depth;
            if (node.left != null)
                queue.Enqueue((node.left, depth + 1));
            if (node.right != null)
                queue.Enqueue((node.right, depth + 1));
        }

        queue.Enqueue((root, 1));
        while (queue.Count > 0)
        {
            var (node, depth) = queue.Dequeue();
            if (depth == maxDepth)
                yield return node;
            if (node.left != null)
            {
                queue.Enqueue((node.left, depth + 1));
                parents.Add(node.left, node);
            }
            if (node.right != null)
            {
                queue.Enqueue((node.right, depth + 1));
                parents.Add(node.right, node);
            }
        }
    }

    private TreeNode FindMinimalSubTreeNode(TreeNode[] nodes, Dictionary<TreeNode, TreeNode> parents)
    {
        var queue = new Queue<TreeNode>(nodes);
        var visited = new HashSet<TreeNode>(nodes);

        while (queue.Count > 1)
        {
            var node = queue.Dequeue();

            if (parents.TryGetValue(node, out var parentNode) && !visited.Contains(parentNode))
            {
                queue.Enqueue(parentNode);
                visited.Add(parentNode);
            }
        }

        return queue.Dequeue();
    }
}