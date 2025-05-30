using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2359._Find_Closest_Node_to_Given_Two_Nodes;

[TestFixture(TestName = "2359. Find Closest Node to Given Two Nodes")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,2,3,-1]", 0, 1, 2)]
    [TestCase("[1,2,-1]", 0, 2, 2)]
    [TestCase("[5,-1,3,4,5,6,-1,-1,4,3]", 0, 0, 0)]
    [TestCase("[-1,-1]", 0, 1, -1)]
    public void Test(string input1, int input2, int input3, int output)
    {
        var solution = new Solution();
        var actual = solution.ClosestMeetingNode(input1.ParseIntArray(), input2, input3);
        Assert.AreEqual(output, actual);
    }
}
