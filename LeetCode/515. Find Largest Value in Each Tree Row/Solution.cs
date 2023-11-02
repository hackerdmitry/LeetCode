using System.Collections.Generic;
using System.Linq;
using LeetCode.__TreeNode;

namespace LeetCode._515._Find_Largest_Value_in_Each_Tree_Row
{
    public class Solution
    {
        public IList<int> LargestValues(TreeNode root)
        {
            var results = new List<int>();
            if (root == null)
                return results;

            var linkedListDepth = new LinkedList<TreeNode>();
            linkedListDepth.AddFirst(root);

            while (linkedListDepth.Count > 0)
            {
                results.Add(linkedListDepth.Max(x => x.val));

                var node = linkedListDepth.First;
                while (node != null)
                {
                    var left = node.Value.left;
                    var right = node.Value.right;

                    if (left != null)
                        linkedListDepth.AddBefore(node, left);
                    if (right != null)
                        linkedListDepth.AddBefore(node, right);

                    var oldNode = node;
                    node = node.Next;
                    linkedListDepth.Remove(oldNode);
                }
            }

            return results;
        }
    }
}