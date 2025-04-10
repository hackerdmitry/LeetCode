using NUnit.Framework;

namespace LeetCode._3._Hard._2999._Count_the_Number_of_Powerful_Integers;

[TestFixture(TestName = "2999. Count the Number of Powerful Integers")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(1193723827, 17591699108481, 7, "20", 16908812288)]
    [TestCase(697662853, 11109609599885, 6, "5", 16135677999)]
    [TestCase(3, 1429, 5, "34", 10)]
    [TestCase(1114, 1864854501, 7, "26", 4194295)]
    [TestCase(1, 6000, 4, "124", 5)]
    [TestCase(1124, 6000, 4, "124", 4)]
    [TestCase(5124, 5124, 4, "124", 0)]
    [TestCase(1124, 1124, 4, "124", 1)]
    [TestCase(52_222, 100_000, 4, "124", 0)]
    [TestCase(15, 215, 6, "10", 2)]
    [TestCase(1000, 2000, 4, "3000", 0)]
    public void Test(long input1, long input2, int input3, string input4, long output)
    {
        var solution = new Solution();
        var actual = solution.NumberOfPowerfulInt(input1, input2, input3, input4);
        Assert.AreEqual(output, actual);
    }
}
