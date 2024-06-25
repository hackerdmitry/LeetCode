using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1038._Binary_Search_Tree_to_Greater_Sum_Tree;

[TestFixture(TestName = "1038. Binary Search Tree to Greater Sum Tree")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[4,1,6,0,2,5,7,null,null,null,3,null,null,null,8]", "[30,36,21,36,35,26,15,null,null,null,33,null,null,null,8]")]
    [TestCase("[0,null,1]", "[1,null,1]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.BstToGst(input.ParseNullIntArray()).ToArray();
        var expected = output.ParseNullIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
