using LeetCode.__Additional;
using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2058._Find_the_Minimum_and_Maximum_Number_of_Nodes_Between_Critical_Points;

[TestFixture(TestName = "2058. Find the Minimum and Maximum Number of Nodes Between Critical Points")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[3,1]", "[-1,-1]")]
    [TestCase("[5,3,1,2,5,1,2]", "[1,3]")]
    [TestCase("[1,3,2,2,3,2,2,2,7]", "[3,3]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.NodesBetweenCriticalPoints(input.ParseIntArray());
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}
