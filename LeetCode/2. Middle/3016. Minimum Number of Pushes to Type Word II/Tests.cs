using NUnit.Framework;

namespace LeetCode._2._Middle._3016._Minimum_Number_of_Pushes_to_Type_Word_II;

[TestFixture(TestName = "3016. Minimum Number of Pushes to Type Word II")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("abcde", 5)]
    [TestCase("xyzxyzxyzxyz", 12)]
    [TestCase("aabbccddeeffgghhiiiiii", 24)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.MinimumPushes(input);
        Assert.AreEqual(output, actual);
    }
}
