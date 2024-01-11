using LeetCode.__TreeNode;

namespace LeetCode._2._Middle._1026._Maximum_Difference_Between_Node_and_Ancestor;

public class Solution
{
    public int MaxAncestorDiff(TreeNode root)
    {
        var (min, max) = FindMaxMinInNode(root, int.MaxValue, int.MinValue);
        return max - min;
    }

    private (int, int) FindMaxMinInNode(TreeNode node, int min, int max)
    {
        if (node.val < min)
            min = node.val;

        if (node.val > max)
            max = node.val;

        var newMinMax = (min, max);

        if (node.left != null)
        {
            var tempMinMax = FindMaxMinInNode(node.left, min, max);
            if (tempMinMax.Item2 - tempMinMax.Item1 > newMinMax.Item2 - newMinMax.Item1)
                newMinMax = tempMinMax;
        }

        if (node.right != null)
        {
            var tempMinMax = FindMaxMinInNode(node.right, min, max);
            if (tempMinMax.Item2 - tempMinMax.Item1 > newMinMax.Item2 - newMinMax.Item1)
                newMinMax = tempMinMax;
        }

        return newMinMax;
    }
}
