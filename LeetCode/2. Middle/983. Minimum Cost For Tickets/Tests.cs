using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._983._Minimum_Cost_For_Tickets;

[TestFixture(TestName = "983. Minimum Cost For Tickets")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[1,5,8,10,13,20,29,31,37,48,52,53,54,61,63,64,65,67,72,73,74,79,81,84,85,86,87,88,91,94,98,100,108,112,115,116,120,121,123,131,132,135,137,139,141,145,147,152,163,165,166,173,174,178,179,182,187,198,202,203,204,206,208,210,212,213,216,224,230,234,237,239,240,242,247,249,250,257,259,261,263,265,266,272,273,274,275,279,280,281,284,288,292,293,297,298,300,301,304,306,309,318,323,326,328,330,332,335,336,339,341,342,345,350,351,362,365]", "[15,8,3]", 39)]
    [TestCase("[1,4,6,7,8,20]", "[7,2,15]", 6)]
    [TestCase("[1,4,6,7,8,20]", "[2,7,15]", 11)]
    [TestCase("[1,2,3,4,5,6,7,8,9,10,30,31]", "[2,7,15]", 17)]
    public void Test(string input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.MincostTickets(input1.ParseIntArray(), input2.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
