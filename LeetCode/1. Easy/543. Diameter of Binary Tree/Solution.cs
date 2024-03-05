using System.Collections.Generic;
using System.Linq;
using LeetCode.__TreeNode;

namespace LeetCode._1._Easy._543._Diameter_of_Binary_Tree;

public class Solution
{
    private List<int> heights = new();

    public int DiameterOfBinaryTree(TreeNode root)
    {
        GetHeights(root, 0);

        var enumerator = heights.OrderByDescending(x => x).GetEnumerator();
        var first = enumerator.MoveNext() ? enumerator.Current : 0;
        var second = enumerator.MoveNext() ? enumerator.Current : 0;

        return first + second;
    }

    private void GetHeights(TreeNode node, int curHeight)
    {
        if (node.left == null && node.right == null)
        {
            heights.Add(curHeight);
            return;
        }

        if (node.left != null)
            GetHeights(node.left, curHeight + 1);

        if (node.right != null)
            GetHeights(node.right, curHeight + 1);
    }
}
