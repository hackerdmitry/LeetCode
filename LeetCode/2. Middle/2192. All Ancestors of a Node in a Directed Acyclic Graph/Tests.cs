using System.Collections.Generic;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2192._All_Ancestors_of_a_Node_in_a_Directed_Acyclic_Graph;

[TestFixture(TestName = "2192. All Ancestors of a Node in a Directed Acyclic Graph")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(8, "[[0,3],[0,4],[1,3],[2,4],[2,7],[3,5],[3,6],[3,7],[4,6]]", "[[],[],[],[0,1],[0,2],[0,1,3],[0,1,2,3,4],[0,1,2,3]]")]
    [TestCase(5, "[[0,1],[0,2],[0,3],[0,4],[1,2],[1,3],[1,4],[2,3],[2,4],[3,4]]", "[[],[0],[0,1],[0,1,2],[0,1,2,3]]")]
    public void Test(int input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.GetAncestors(input1, input2.ParseIntArray2d());
        var expected = output.ParseIntArray2d();
        actual.WriteLine("actual");
        expected.WriteLine("expected");
        Assert.AreEqual(expected, actual);
    }
}
