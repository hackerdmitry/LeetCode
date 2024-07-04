using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2181._Merge_Nodes_in_Between_Zeros;

[TestFixture(TestName = "2181. Merge Nodes in Between Zeros")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[0,3,1,0,4,5,2,0]", "[4,11]")]
    [TestCase("[0,1,0,3,0,2,2,0]", "[1,3,4]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.MergeNodes(input.ParseIntArray()).ToArray();
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}
