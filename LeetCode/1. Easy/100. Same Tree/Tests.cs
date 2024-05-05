using System.Collections;
using LeetCode.__Additional;
using NUnit.Framework;

namespace LeetCode._1._Easy._100._Same_Tree;

[TestFixture(TestName = "100. Same Tree")]
public class Tests
{
    [Timeout(1000)]
    [TestCaseSource(nameof(Input))]
    public void Test(int?[] input1, int?[] input2, bool output)
    {
        var solution = new Solution();

        var treeRoot1 = TreeNode.CreateFromArray(input1);
        var treeRoot2 = TreeNode.CreateFromArray(input2);
        var actual = solution.IsSameTree(treeRoot1, treeRoot2);

        Assert.AreEqual(output, actual);
    }

    private static IEnumerable Input()
    {
        yield return new object[]
        {
            new int?[] {1, 2, 3},
            new int?[] {1, 2, 3},
            true,
        };
        yield return new object[]
        {
            new int?[] {1, 2},
            new int?[] {1, null, 2},
            false,
        };
        yield return new object[]
        {
            new int?[] {1, 2, 1},
            new int?[] {1, 1, 2},
            false,
        };
        yield return new object[]
        {
            new int?[] {1},
            new int?[] {1, null, 2},
            false,
        };
    }
}