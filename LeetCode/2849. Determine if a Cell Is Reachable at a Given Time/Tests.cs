using NUnit.Framework;

namespace LeetCode._2849._Determine_if_a_Cell_Is_Reachable_at_a_Given_Time;

[TestFixture(TestName = "2849. Determine if a Cell Is Reachable at a Given Time")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(2, 4, 7, 7, 6, true)]
    [TestCase(3, 1, 7, 3, 3, false)]
    [TestCase(1, 2, 1, 2, 1, false)]
    [TestCase(1, 1, 1, 1, 3, true)]
    public void Test(int input1, int input2, int input3, int input4, int input5, bool output)
    {
        var solution = new Solution();
        var actual = solution.IsReachableAtTime(input1, input2, input3, input4, input5);
        Assert.AreEqual(output, actual);
    }
}