using NUnit.Framework;

namespace LeetCode._2._Middle._567._Permutation_in_String;

[TestFixture(TestName = "560. Subarray Sum Equals K")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("ab", "eidbaooo", true)]
    [TestCase("ab", "eidboaoo", false)]
    public void Test(string input1, string input2, bool output)
    {
        var solution = new Solution();
        var actual = solution.CheckInclusion(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
