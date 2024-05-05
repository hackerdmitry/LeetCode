using System.Collections;
using LeetCode.__Additional;
using NUnit.Framework;

namespace LeetCode._1._Easy._938._Range_Sum_of_BST;

[TestFixture(TestName = "938. Range Sum of BST")]
public class Tests
{
    [Timeout(1000)]
    [TestCaseSource(nameof(Input))]
    public void Test(int?[] input1, int input2, int input3, int output)
    {
        var solution = new Solution();
        var treeRoot = TreeNode.CreateFromArray(input1);
        var actual = solution.RangeSumBST(treeRoot, input2, input3);
        Assert.AreEqual(output, actual);
    }

    private static IEnumerable Input()
    {
        yield return new object[]
        {
            new int?[] {10, 5, 15, 3, 7, null, 18}, 7, 15,
            32,
        };
        yield return new object[]
        {
            new int?[] {10, 5, 15, 3, 7, 13, 18, 1, null, 6}, 6, 10,
            23,
        };
    }
}