using NUnit.Framework;

namespace LeetCode._3._Hard._514._Freedom_Trail;

[TestFixture(TestName = "514. Freedom Trail")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("godding", "gd", 4)]
    [TestCase("godding", "godding", 13)]
    public void Test(string input1, string input2, int output)
    {
        var solution = new Solution();
        var actual = solution.FindRotateSteps(input1, input2);
        Assert.AreEqual(output, actual);
    }
}
