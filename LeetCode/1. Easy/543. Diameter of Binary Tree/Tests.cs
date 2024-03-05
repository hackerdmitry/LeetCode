using System.Collections;
using LeetCode.__TreeNode;
using NUnit.Framework;

namespace LeetCode._1._Easy._543._Diameter_of_Binary_Tree;

[TestFixture(TestName = "543. Diameter of Binary Tree")]
public class Tests
{
    [Timeout(1000)]
    [TestCaseSource(nameof(Input))]
    public void Test(int?[] input, int output)
    {
        var solution = new Solution();

        var treeRoot = TreeNode.CreateFromArray(input);
        var actual = solution.DiameterOfBinaryTree(treeRoot);

        Assert.AreEqual(output, actual);
    }

    private static IEnumerable Input()
    {
        yield return new object[]
        {
            new int?[]{1,2,3,4,5},
            3
        };
        yield return new object[]
        {
            new int?[]{1,2},
            1
        };
    }
}
