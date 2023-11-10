using System.Collections.Generic;
using System.Linq;
using LeetCode.__TreeNode;

namespace LeetCode._1._Easy._501._Find_Mode_in_Binary_Search_Tree;

public class Solution
{
    public int[] FindMode(TreeNode root)
    {
        var dict = new Dictionary<int, int>();

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var treeNode = queue.Dequeue();

            if (dict.ContainsKey(treeNode.val))
                dict[treeNode.val]++;
            else
                dict[treeNode.val] = 1;

            if (treeNode.left != null)
                queue.Enqueue(treeNode.left);

            if (treeNode.right != null)
                queue.Enqueue(treeNode.right);
        }

        var maxCount = -1;
        var result = new List<int>();
        foreach (var pair in dict.OrderByDescending(x => x.Value))
        {
            if (maxCount == -1)
                maxCount = pair.Value;

            if (pair.Value == maxCount)
                result.Add(pair.Key);
            else
                break;
        }

        return result.ToArray();
    }
}