using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3440._Reschedule_Meetings_for_Maximum_Free_Time_II;

[TestFixture(TestName = "3440. Reschedule Meetings for Maximum Free Time II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(5, "[1,3]", "[2,5]", 2)]
    [TestCase(41, "[17,24]", "[19,25]", 24)]
    [TestCase(10, "[0,7,9]", "[1,8,10]", 7)]
    [TestCase(10, "[0,3,7,9]", "[1,4,8,10]", 6)]
    [TestCase(5, "[0,1,2,3,4]", "[1,2,3,4,5]", 0)]
    public void Test(int input1, string input2, string input3, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxFreeTime(input1, input2.ParseIntArray(), input3.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
