using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LeetCode.__TreeNode;

namespace LeetCode._2._Middle._1457._Pseudo_Palindromic_Paths_in_a_Binary_Tree;

public class Solution
{
    public int PseudoPalindromicPaths(TreeNode root)
    {
        var result = 0;

        var queue = new Queue<(TreeNode, int[], int)>();

        var rootValues = new int[9];
        rootValues[root.val - 1]++;
        queue.Enqueue((root, rootValues, 1));

        while (queue.Count != 0)
        {
            var (node, values, count) = queue.Dequeue();

            if (node.left != null)
            {
                if (node.right != null)
                {
                    var copyValues = new int[9];
                    values.CopyTo(copyValues, 0);
                    values[node.left.val - 1]++;
                    copyValues[node.right.val - 1]++;
                    queue.Enqueue((node.left, values, count + 1));
                    queue.Enqueue((node.right, copyValues, count + 1));
                }
                else
                {
                    values[node.left.val - 1]++;
                    queue.Enqueue((node.left, values, count + 1));
                }
            }
            else
            {
                if (node.right != null)
                {
                    values[node.right.val - 1]++;
                    queue.Enqueue((node.right, values, count + 1));
                }
                else
                {
                    if (IsPalindromic(values, count))
                        result++;
                }
            }
        }

        return result;
    }

    private bool IsPalindromic(int[] values, int count) =>
        count % 2 == 0
            ? values.All(x => x % 2 == 0)
            : values.Count(x => x % 2 != 0) == 1;
}
