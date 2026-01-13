using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._700._Search_in_a_Binary_Search_Tree;

[TestFixture(TestName = "700. Search in a Binary Search Tree")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[4,2,7,1,3]", 2, "[2,1,3]")]
    [TestCase("[4,2,7,1,3]", 5, "[]")]
    public void Test(string input1, int input2, string output)
    {
        var solution = new Solution();
        var actual = solution.SearchBST(input1.ParseNullIntArray(), input2);
        Assert.AreEqual(output.ParseNullIntArray(), actual.ToArray());
    }
}
