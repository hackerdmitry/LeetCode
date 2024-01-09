using System;
using System.Collections.Generic;
using System.Linq;
using LeetCode.__TreeNode;

namespace LeetCode._1._Easy._872._Leaf_Similar_Trees;

public class Solution
{
    public bool LeafSimilar(TreeNode root1, TreeNode root2)
    {
        var leafListRoot1 = new List<int>();
        FillLeafList(root1, leafListRoot1);
        var leafListRoot2 = new List<int>();
        FillLeafList(root2, leafListRoot2);

        return leafListRoot1.Count == leafListRoot2.Count &&
               Enumerable.Range(0, leafListRoot1.Count).All(i => leafListRoot1[i] == leafListRoot2[i]);
    }

    private void FillLeafList(TreeNode node, List<int> leafList)
    {
        if (node.left == null && node.right == null)
        {
            leafList.Add(node.val);
            return;
        }

        if (node.left != null)
            FillLeafList(node.left, leafList);

        if (node.right != null)
            FillLeafList(node.right, leafList);
    }
}
