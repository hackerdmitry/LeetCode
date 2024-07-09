using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._1701._Average_Waiting_Time;

[TestFixture(TestName = "1701. Average Waiting Time")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[1,2],[2,5],[4,3]]", 5.00000)]
    [TestCase("[[5,2],[5,4],[10,3],[20,1]]", 3.25000)]
    public void Test(string input, double output)
    {
        var solution = new Solution();
        var actual = solution.AverageWaitingTime(input.ParseIntArray2d());
        Assert.AreEqual(output, actual, 1e-5);
    }
}
