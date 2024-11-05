using NUnit.Framework;

namespace LeetCode._2._Middle._2914._Minimum_Number_of_Changes_to_Make_Binary_String_Beautiful;

[TestFixture(TestName = "2914. Minimum Number of Changes to Make Binary String Beautiful")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("1001", 2)]
    [TestCase("10", 1)]
    [TestCase("0000", 0)]
    [TestCase("11000111", 1)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinChanges(input);
        Assert.AreEqual(output, actual);
    }
}
