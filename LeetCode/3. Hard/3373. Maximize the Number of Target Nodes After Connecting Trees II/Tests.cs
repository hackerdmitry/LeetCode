using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._3373._Maximize_the_Number_of_Target_Nodes_After_Connecting_Trees_II;

[TestFixture(TestName = "3373. Maximize the Number of Target Nodes After Connecting Trees II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[0,1],[0,2],[2,3],[2,4]]", "[[0,1],[0,2],[0,3],[2,7],[1,4],[4,5],[4,6]]", "[8,7,7,8,8]")]
    [TestCase("[[0,1],[0,2],[0,3],[0,4]]", "[[0,1],[1,2],[2,3]]", "[3,6,6,6,6]")]
    public void Test(string input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.MaxTargetNodes(input1.ParseIntArray2d(), input2.ParseIntArray2d());
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}
