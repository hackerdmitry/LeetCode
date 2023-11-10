using LeetCode.__TreeNode;

namespace LeetCode._2._Middle._2265._Count_Nodes_Equal_to_Average_of_Subtree;

public class Solution
{
    public int AverageOfSubtree(TreeNode root)
    {
        return CountAverages(root).CountAverages;
    }

    private (int Count, int Sum, int CountAverages) CountAverages(TreeNode treeNode)
    {
        var count = 1;
        var sum = treeNode.val;
        var countAverages = 0;

        if (treeNode.left != null)
        {
            var (countLeft, sumLeft, countAveragesLeft) = CountAverages(treeNode.left);
            count += countLeft;
            sum += sumLeft;
            countAverages += countAveragesLeft;
        }

        if (treeNode.right != null)
        {
            var (countRight, sumRight, countAveragesRight) = CountAverages(treeNode.right);
            count += countRight;
            sum += sumRight;
            countAverages += countAveragesRight;
        }

        if (sum / count == treeNode.val)
            countAverages++;

        return (count, sum, countAverages);
    }
}