using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._2094._Finding_3_Digit_Even_Numbers;

[TestFixture(TestName = "2094. Finding 3-Digit Even Numbers")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[2,1,3,0]", "[102,120,130,132,210,230,302,310,312,320]")]
    [TestCase("[2,2,8,8,2]", "[222,228,282,288,822,828,882]")]
    [TestCase("[3,7,5]", "[]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.FindEvenNumbers(input.ParseIntArray());
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}