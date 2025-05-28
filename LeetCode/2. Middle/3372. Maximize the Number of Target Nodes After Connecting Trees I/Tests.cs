using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3372._Maximize_the_Number_of_Target_Nodes_After_Connecting_Trees_I;

[TestFixture(TestName = "3372. Maximize the Number of Target Nodes After Connecting Trees I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[0,1],[0,2],[0,3],[0,4]]", "[[0,1],[1,2],[2,3]]", 1, "[6,3,3,3,3]")]
    [TestCase("[[0,1],[0,2],[2,3],[2,4]]", "[[0,1],[0,2],[0,3],[2,7],[1,4],[4,5],[4,6]]", 2, "[9,7,9,8,8]")]
    public void Test(string input1, string input2, int input3, string output)
    {
        var solution = new Solution();
        var actual = solution.MaxTargetNodes(input1.ParseIntArray2d(), input2.ParseIntArray2d(), input3);
        var expected = output.ParseIntArray();
        expected.WriteLine("expected");
        actual.WriteLine("actual");
        Assert.AreEqual(expected, actual);
    }
}
