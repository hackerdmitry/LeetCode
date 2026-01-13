using LeetCode.__Additional;

namespace LeetCode._1._Easy._700._Search_in_a_Binary_Search_Tree;

public class Solution
{
    public TreeNode SearchBST(TreeNode root, int val)
    {
        var node = root;
        while (node != null)
        {
            if (node.val == val)
                return node;

            node = val < node.val ? node.left : node.right;
        }

        return null;
    }
}