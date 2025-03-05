using NUnit.Framework;

namespace LeetCode._2._Middle._2579._Count_Total_Number_of_Colored_Cells;

[TestFixture(TestName = "2579. Count Total Number of Colored Cells")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(1, 1)]
    [TestCase(2, 5)]
    [TestCase(3, 13)]
    [TestCase(4, 25)]
    public void Test(int input, long output)
    {
        var solution = new Solution();
        var actual = solution.ColoredCells(input);
        Assert.AreEqual(output, actual);
    }
}
