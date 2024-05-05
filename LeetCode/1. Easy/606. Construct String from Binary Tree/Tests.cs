using System.Collections;
using LeetCode.__Additional;
using NUnit.Framework;

namespace LeetCode._1._Easy._606._Construct_String_from_Binary_Tree;

[TestFixture(TestName = "606. Construct String from Binary Tree")]
public class Tests
{
    [Timeout(1000)]
    [TestCaseSource(nameof(Input))]
    public void Test(int?[] input, string output)
    {
        var solution = new Solution();

        var treeRoot = TreeNode.CreateFromArray(input);
        var actual = solution.Tree2str(treeRoot);

        Assert.AreEqual(output, actual);
    }

    private static IEnumerable Input()
    {
        yield return new object[]
        {
            new int?[] {1, 2, 3, 4},
            "1(2(4))(3)",
        };
        yield return new object[]
        {
            new int?[] {1, 2, 3, null, 4},
            "1(2()(4))(3)",
        };
    }
}