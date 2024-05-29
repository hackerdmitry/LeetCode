using NUnit.Framework;

namespace LeetCode._2._Middle._1404._Number_of_Steps_to_Reduce_a_Number_in_Binary_Representation_to_One;

[TestFixture(TestName = "1404. Number of Steps to Reduce a Number in Binary Representation to One")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("1101", 6)]
    [TestCase("10", 1)]
    [TestCase("1", 0)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.NumSteps(input);
        Assert.AreEqual(output, actual);
    }
}
