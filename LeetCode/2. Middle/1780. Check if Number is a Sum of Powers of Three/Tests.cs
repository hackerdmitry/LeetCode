using NUnit.Framework;

namespace LeetCode._2._Middle._1780._Check_if_Number_is_a_Sum_of_Powers_of_Three;

[TestFixture(TestName = "1780. Check if Number is a Sum of Powers of Three")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(12, true)]
    [TestCase(91, true)]
    [TestCase(21, false)]
    public void Test(int input, bool output)
    {
        var solution = new Solution();
        var actual = solution.CheckPowersOfThree(input);
        Assert.AreEqual(output, actual);
    }
}
