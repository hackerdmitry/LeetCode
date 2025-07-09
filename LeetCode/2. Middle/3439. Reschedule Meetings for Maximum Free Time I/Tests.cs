using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3439._Reschedule_Meetings_for_Maximum_Free_Time_I;

[TestFixture(TestName = "3439. Reschedule Meetings for Maximum Free Time I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(5, 1, "[1,3]", "[2,5]", 2)]
    [TestCase(10, 1, "[0,2,9]", "[1,4,10]", 6)]
    [TestCase(5, 2, "[0,1,2,3,4]", "[1,2,3,4,5]", 0)]
    public void Test(int input1, int input2, string input3, string input4, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxFreeTime(input1, input2, input3.ParseIntArray(), input4.ParseIntArray());
        Assert.AreEqual(output, actual);
    }
}
