using NUnit.Framework;

namespace LeetCode._1._Easy._1758._Minimum_Changes_To_Make_Alternating_Binary_String;

[TestFixture(TestName = "1758. Minimum Changes To Make Alternating Binary String")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("0100", 1)]
    [TestCase("10", 0)]
    [TestCase("1111", 2)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinOperations(input);
        Assert.AreEqual(output, actual);
    }
}
