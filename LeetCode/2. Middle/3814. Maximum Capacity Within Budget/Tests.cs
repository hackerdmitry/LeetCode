using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3814._Maximum_Capacity_Within_Budget;

[TestFixture(TestName = "3814. Maximum Capacity Within Budget")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,2,4]", "[1,8,5]", 11, 13)]
    [TestCase("[8,7,1]", "[7,4,2]", 11, 9)]
    [TestCase("[3,5,7,4]", "[2,4,3,6]", 7, 6)]
    [TestCase("[4,8,5,3]", "[1,5,2,7]", 8, 8)]
    [TestCase("[1,7,3]", "[7,3,5]", 13, 12)]
    [TestCase("[1,12,2,4,1,11,8]", "[2,11,3,7,7,12,3]", 14, 19)]
    [TestCase("[2,2,2]", "[3,5,4]", 5, 9)]
    [TestCase("[4,6]", "[5,3]", 3, 0)]
    public void Test(string input1, string input2, int input3, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxCapacity(input1.ParseIntArray(), input2.ParseIntArray(), input3);
        Assert.AreEqual(output, actual);
    }
}