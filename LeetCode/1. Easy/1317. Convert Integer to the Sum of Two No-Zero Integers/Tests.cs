using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1317._Convert_Integer_to_the_Sum_of_Two_No_Zero_Integers;

[TestFixture(TestName = "1317. Convert Integer to the Sum of Two No-Zero Integers")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(2, "[1,1]")]
    [TestCase(11, "[2,9]")]
    public void Test(int input, string output)
    {
        var solution = new Solution();
        var actual = solution.GetNoZeroIntegers(input);
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}
