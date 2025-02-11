using NUnit.Framework;

namespace LeetCode._2._Middle._1910._Remove_All_Occurrences_of_a_Substring;

[TestFixture(TestName = "1910. Remove All Occurrences of a Substring")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("daabcbaabcbc", "abc", "dab")]
    [TestCase("axxxxyyyyb", "xy", "ab")]
    public void Test(string input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.RemoveOccurrences(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
