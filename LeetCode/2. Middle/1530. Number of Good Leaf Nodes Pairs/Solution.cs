using System.Collections.Generic;
using LeetCode.__Additional;

namespace LeetCode._2._Middle._1530._Number_of_Good_Leaf_Nodes_Pairs;

public class Solution
{
    public int CountPairs(TreeNode root, int distance)
    {
        var parents = new Dictionary<TreeNode, TreeNode>();
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        var leafs = new HashSet<TreeNode>();

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();

            if (node.left != null)
            {
                parents[node.left] = node;
                queue.Enqueue(node.left);
            }

            if (node.right != null)
            {
                parents[node.right] = node;
                queue.Enqueue(node.right);
            }

            if (node.left == null && node.right == null)
                leafs.Add(node);
        }

        var result = 0;

        var distanceQueue = new Queue<(TreeNode, int, TreeNode)>();
        foreach (var leaf in leafs)
        {
            distanceQueue.Enqueue((leaf, distance, null));
            while (distanceQueue.Count > 0)
            {
                var (node, remainDistance, prevNode) = distanceQueue.Dequeue();

                if (leafs.Contains(node) && prevNode != null)
                {
                    result++;
                    continue;
                }

                if (remainDistance > 0)
                {
                    if (parents.TryGetValue(node, out var parentNode) && parentNode != prevNode)
                        distanceQueue.Enqueue((parentNode, remainDistance - 1, node));
                    if (node.left != null && node.left != prevNode)
                        distanceQueue.Enqueue((node.left, remainDistance - 1, node));
                    if (node.right != null && node.right != prevNode)
                        distanceQueue.Enqueue((node.right, remainDistance - 1, node));
                }
            }
        }

        return result / 2;
    }
}