using System.Collections.Generic;
using System.Linq;
using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1110._Delete_Nodes_And_Return_Forest;

[TestFixture(TestName = "1110. Delete Nodes And Return Forest")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,4,5,6,7]", "[3,5]", "[[1,2,null,4],[6],[7]]")]
    [TestCase("[1,2,4,null,3]", "[3]", "[[1,2,4]]")]
    [TestCase("[1,2,null,4,3]", "[2,3]", "[[1],[4]]")]
    public void Test(string input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.DelNodes(input1.ParseNullIntArray(), input2.ParseIntArray());
        Assert.AreEqual(
            output,
            $"[{string.Join(',', actual.Select(x => $"[{string.Join(',', x.ToArray().Select(x => x.HasValue ? x.ToString() : "null"))}]"))}]");
    }
}