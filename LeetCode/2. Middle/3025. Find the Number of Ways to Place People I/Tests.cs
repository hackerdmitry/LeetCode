using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3025._Find_the_Number_of_Ways_to_Place_People_I;

[TestFixture(TestName = "3025. Find the Number of Ways to Place People I")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[1,1],[2,2],[3,3]]", 0)]
    [TestCase("[[6,2],[4,4],[2,6]]", 2)]
    [TestCase("[[3,1],[1,3],[1,1]]", 2)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.NumberOfPairs(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
