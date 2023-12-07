using NUnit.Framework;

namespace LeetCode._1._Easy._1903._Largest_Odd_Number_in_String;

[TestFixture(TestName = "1903. Largest Odd Number in String")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("52", "5")]
    [TestCase("4206", "")]
    [TestCase("35427", "35427")]
    public void Test(string input, string output)
    {
        var solution = new Solution();
        var actual = solution.LargestOddNumber(input);
        Assert.AreEqual(output, actual);
    }
}
