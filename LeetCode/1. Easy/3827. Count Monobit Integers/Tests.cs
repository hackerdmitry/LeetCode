using NUnit.Framework;

namespace LeetCode._1._Easy._3827._Count_Monobit_Integers;

[TestFixture(TestName = "3827. Count Monobit Integers")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(1, 2)]
    [TestCase(4, 3)]
    public void Test(int input, int output)
    {
        var solution = new Solution();
        var actual = solution.CountMonobit(input);
        Assert.AreEqual(output, actual);
    }
}
