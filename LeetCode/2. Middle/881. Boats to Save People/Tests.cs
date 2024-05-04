using NUnit.Framework;

namespace LeetCode._2._Middle._881._Boats_to_Save_People;

[TestFixture(TestName = "881. Boats to Save People")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(new[] {1, 2}, 3, 1)]
    [TestCase(new[] {3, 2, 2, 1}, 3, 3)]
    [TestCase(new[] {3, 5, 3, 4}, 5, 4)]
    [TestCase(new[] {1, 1, 1, 2, 2, 2}, 3, 3)]
    [TestCase(new[] {3, 2, 3, 2, 2}, 6, 3)]
    public void Test(int[] input1, int input2, int output)
    {
        var solution = new Solution();
        var actual = solution.NumRescueBoats(input1, input2);
        Assert.AreEqual(output, actual);
    }
}