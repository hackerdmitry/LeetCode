using System.Collections;
using LeetCode.__TreeNode;
using NUnit.Framework;

namespace LeetCode._1._Easy._872._Leaf_Similar_Trees;

[TestFixture(TestName = "872. Leaf-Similar Trees")]
public class Tests
{
    [Timeout(1000)]
    [TestCaseSource(nameof(Input))]
    public void Test(int?[] input1, int?[] input2, bool output)
    {
        var solution = new Solution();
        var treeRoot1 = TreeNode.CreateFromArray(input1);
        var treeRoot2 = TreeNode.CreateFromArray(input2);
        var actual = solution.LeafSimilar(treeRoot1, treeRoot2);
        Assert.AreEqual(output, actual);
    }

    private static IEnumerable Input()
    {
        yield return new object[]
        {
            new int?[]{3,5,1,6,2,9,8,null,null,7,4},
            new int?[]{3,5,1,6,7,4,2,null,null,null,null,null,null,9,8},
            true,
        };
        yield return new object[]
        {
            new int?[]{1,2,3},
            new int?[]{1,3,2},
            false,
        };
    }
}
