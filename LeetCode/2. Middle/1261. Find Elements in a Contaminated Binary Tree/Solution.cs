using System.Collections.Generic;
using LeetCode.__Additional;

namespace LeetCode._2._Middle._1261._Find_Elements_in_a_Contaminated_Binary_Tree;

public class FindElements
{
    private readonly HashSet<int> hashSet = new();
    private const int maxValue = 1_000_000;

    public FindElements(TreeNode root)
    {
        root.val = 0;
        hashSet.Add(root.val);
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();

            if (node.left != null)
            {
                var target = node.val * 2 + 1;
                if (target <= maxValue)
                {
                    node.left.val = target;
                    hashSet.Add(target);
                    queue.Enqueue(node.left);
                }
            }

            if (node.right != null)
            {
                var target = node.val * 2 + 2;
                if (target <= maxValue)
                {
                    node.right.val = target;
                    hashSet.Add(target);
                    queue.Enqueue(node.right);
                }
            }
        }
    }

    public bool Find(int target)
    {
        return hashSet.Contains(target);
    }
}