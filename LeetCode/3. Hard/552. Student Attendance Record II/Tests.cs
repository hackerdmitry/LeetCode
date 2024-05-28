using NUnit.Framework;

namespace LeetCode._3._Hard._552._Student_Attendance_Record_II;

[TestFixture(TestName = "552. Student Attendance Record II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(2, 8)]
    [TestCase(1, 3)]
    [TestCase(3, 19)]
    [TestCase(10101, 183236316)]
    public void Test(int input, int output)
    {
        var solution = new Solution();
        var actual = solution.CheckRecord(input);
        Assert.AreEqual(output, actual);
    }
}