using NUnit.Framework;

namespace LeetCode._2._Middle._1653._Minimum_Deletions_to_Make_String_Balanced;

[TestFixture(TestName = "1653. Minimum Deletions to Make String Balanced")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("aababbab", 2)]
    [TestCase("bbaaaaabb", 2)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinimumDeletions(input);
        Assert.AreEqual(output, actual);
    }
}
