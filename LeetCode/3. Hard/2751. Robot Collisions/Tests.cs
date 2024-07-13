using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._3._Hard._2751._Robot_Collisions;

[TestFixture(TestName = "2751. Robot Collisions")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[12,33,37]", "[49,5,38]", "RLL", "[47]")]
    [TestCase("[11,44,16]", "[1,20,17]", "RLR", "[18]")]
    [TestCase("[5,46,12]", "[3,27,43]", "RLL", "[27,42]")]
    [TestCase("[3,5,2,6]", "[10,10,15,12]", "RLRL", "[14]")]
    [TestCase("[5,4,3,2,1]", "[2,17,9,15,10]", "RRRRR", "[2,17,9,15,10]")]
    [TestCase("[1,2,5,6]", "[10,10,11,11]", "RLRL", "[]")]
    public void Test(string input1, string input2, string input3, string output)
    {
        var solution = new Solution();
        var actual = solution.SurvivedRobotsHealths(input1.ParseIntArray(), input2.ParseIntArray(), input3);
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}