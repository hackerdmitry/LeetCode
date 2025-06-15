using NUnit.Framework;

namespace LeetCode._2._Middle._1432._Max_Difference_You_Can_Get_From_Changing_an_Integer;

[TestFixture(TestName = "1432. Max Difference You Can Get From Changing an Integer")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(105, 805)]
    [TestCase(9288, 8700)]
    [TestCase(555, 888)]
    [TestCase(9, 8)]
    [TestCase(100, 800)]
    [TestCase(111, 888)]
    [TestCase(999, 888)]
    public void Test(int input, int output)
    {
        var solution = new Solution();
        var actual = solution.MaxDiff(input);
        Assert.AreEqual(output, actual);
    }
}