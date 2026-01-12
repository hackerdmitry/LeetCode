using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1448._Count_Good_Nodes_in_Binary_Tree;

[TestFixture(TestName = "1448. Count Good Nodes in Binary Tree")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[3,1,4,3,null,1,5]", 4)]
    [TestCase("[3,3,null,4,2]", 3)]
    [TestCase("[1]", 1)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.GoodNodes(input.ParseNullIntArray());
        Assert.AreEqual(output, actual);
    }
}
