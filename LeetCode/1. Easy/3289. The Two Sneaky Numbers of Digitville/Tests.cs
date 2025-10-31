using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._3289._The_Two_Sneaky_Numbers_of_Digitville;

[TestFixture(TestName = "3289. The Two Sneaky Numbers of Digitville")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[0,1,1,0]", "[0,1]")]
    [TestCase("[0,3,2,1,3,2]", "[2,3]")]
    [TestCase("[7,1,5,4,3,4,6,0,9,5,8,2]", "[4,5]")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.GetSneakyNumbers(input.ParseIntArray());
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}
