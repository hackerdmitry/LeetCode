using System.Collections.Generic;
using System.Linq;
using LeetCode.__Additional;

namespace LeetCode._2._Middle._1123._Lowest_Common_Ancestor_of_Deepest_Leaves;

public class Solution
{
    public TreeNode LcaDeepestLeaves(TreeNode root)
    {
        var depthList = new List<LinkedList<TreeNode>>();
        var rootLinkedList = new LinkedList<TreeNode>();
        rootLinkedList.AddLast(root);
        depthList.Add(rootLinkedList);

        var nodes = new Dictionary<int, (TreeNode Node, int Depth, TreeNode Parent)>
        {
            [root.val] = (root, 0, null),
        };

        var depthQueue = new Queue<(TreeNode, int)>();
        depthQueue.Enqueue((root, 0));

        while (depthQueue.Count > 0)
        {
            var (node, depth) = depthQueue.Dequeue();
            var childDepth = depth + 1;
            if (node.left != null)
            {
                depthQueue.Enqueue((node.left, childDepth));
                if (depthList.Count <= childDepth)
                    depthList.Add(new LinkedList<TreeNode>());
                depthList[childDepth].AddLast(node.left);
                nodes[node.left.val] = (node.left, depth + 1, node);
            }
            if (node.right != null)
            {
                depthQueue.Enqueue((node.right, childDepth));
                if (depthList.Count <= childDepth)
                    depthList.Add(new LinkedList<TreeNode>());
                depthList[childDepth].AddLast(node.right);
                nodes[node.right.val] = (node.right, depth + 1, node);
            }
        }

        var countAncestors = new Dictionary<int, int>();
        var ancestorsQueue = new Queue<TreeNode>();
        foreach (var node in depthList[^1])
        {
            ancestorsQueue.Enqueue(node);
            countAncestors[node.val] = 1;
        }

        while (ancestorsQueue.Count > 0)
        {
            var node = ancestorsQueue.Dequeue();
            if (node.val != root.val)
            {
                var parent = nodes[node.val];
                if (!countAncestors.TryAdd(parent.Parent.val, countAncestors[node.val]))
                    countAncestors[parent.Parent.val] += countAncestors[node.val];
                else
                    ancestorsQueue.Enqueue(parent.Parent);
            }
        }

        var lca = countAncestors
            .Where(x => x.Value == depthList[^1].Count)
            .Select(x => nodes[x.Key])
            .MaxBy(x => x.Depth)
            .Node;
        return lca;
    }
}
