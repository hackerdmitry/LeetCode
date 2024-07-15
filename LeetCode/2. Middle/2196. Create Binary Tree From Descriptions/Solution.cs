using System.Collections.Generic;
using System.Linq;
using LeetCode.__Additional;

namespace LeetCode._2._Middle._2196._Create_Binary_Tree_From_Descriptions;

public class Solution
{
    public TreeNode CreateBinaryTree(int[][] descriptions)
    {
        var nodes = new Dictionary<int, Node>();

        foreach (var description in descriptions)
        {
            var (parent, child, isLeft) = (description[0], description[1], description[2] == 1);

            if (!nodes.ContainsKey(parent))
                nodes[parent] = new Node(new TreeNode(parent));
            var parentNode = nodes[parent];

            if (!nodes.ContainsKey(child))
                nodes[child] = new Node(new TreeNode(child));
            var childNode = nodes[child];

            childNode.Parent = parentNode;

            if (isLeft)
                parentNode.This.left = childNode.This;
            else
                parentNode.This.right = childNode.This;
        }

        var node = nodes.First().Value;
        while (node.Parent != null)
            node = node.Parent;

        return node.This;
    }

    class Node
    {
        public TreeNode This { get; set; }
        public Node Parent { get; set; }

        public Node(TreeNode @this)
        {
            This = @this;
        }
    }
}
