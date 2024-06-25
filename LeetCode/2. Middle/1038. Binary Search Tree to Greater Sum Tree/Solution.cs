using System.Collections;
using System.Collections.Generic;
using LeetCode.__Additional;
using LeetCode._3._Hard._2642._Design_Graph_With_Shortest_Path_Calculator;

namespace LeetCode._2._Middle._1038._Binary_Search_Tree_to_Greater_Sum_Tree;

public class Solution
{
    public TreeNode BstToGst(TreeNode root)
    {
        var sum = 0;
        var toReturn = new Stack<TreeNode>();

        var copyRoot = root;
        while (copyRoot != null)
        {
            toReturn.Push(copyRoot);
            copyRoot = copyRoot.right;
        }

        while (toReturn.Count != 0)
        {
            var node = toReturn.Pop();
            sum += node.val;
            node.val = sum;

            node = node.left;
            while (node != null)
            {
                toReturn.Push(node);
                node = node.right;
            }
        }

        return root;
    }
}
