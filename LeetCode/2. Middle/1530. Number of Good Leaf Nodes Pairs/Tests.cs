using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1530._Number_of_Good_Leaf_Nodes_Pairs;

[TestFixture(TestName = "1530. Number of Good Leaf Nodes Pairs")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,3,null,4]", 3, 1)]
    [TestCase("[1,2,3,4,5,6,7]", 3, 2)]
    [TestCase("[7,1,4,6,null,5,3,null,null,null,null,null,2]", 3, 1)]
    public void Test(string input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.CountPairs(input1.ParseNullIntArray(), input2);
        Assert.AreEqual(output, actual);
    }
}