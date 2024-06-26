using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1382._Balance_a_Binary_Search_Tree;

[TestFixture(TestName = "1382. Balance a Binary Search Tree")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,null,2,null,3,null,4,null,null]", "[2,1,3,null,null,null,4]")]
    [TestCase("[2,1,3]", "[2,1,3]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.BalanceBST(input.ParseNullIntArray()).ToArray();
        Assert.AreEqual(output.ParseNullIntArray(), actual);
    }
}
