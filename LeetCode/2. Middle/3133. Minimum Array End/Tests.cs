using NUnit.Framework;

namespace LeetCode._2._Middle._3133._Minimum_Array_End;

[TestFixture(TestName = "3133. Minimum Array End")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(6715154, 7193485, 55012476815)]
    [TestCase(1, 2, 2)]
    [TestCase(3, 4, 6)]
    [TestCase(2, 7, 15)]
    public void Test(int input1, int input2, long output)
    {
        var solution = new Solution();
        var actual = solution.MinEnd(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
