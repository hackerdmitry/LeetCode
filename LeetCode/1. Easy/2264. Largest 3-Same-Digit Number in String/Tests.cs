using NUnit.Framework;

namespace LeetCode._1._Easy._2264._Largest_3_Same_Digit_Number_in_String;

[TestFixture(TestName = "2264. Largest 3-Same-Digit Number in String")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("6777133339", "777")]
    [TestCase("2300019", "000")]
    [TestCase("42352338", "")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.LargestGoodInteger(input);
        Assert.AreEqual(output, actual);
    }
}
