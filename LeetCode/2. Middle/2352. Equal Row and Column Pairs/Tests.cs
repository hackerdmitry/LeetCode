using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2352._Equal_Row_and_Column_Pairs;

[TestFixture(TestName = "2352. Equal Row and Column Pairs")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[3,2,1],[1,7,6],[2,7,7]]", 1)]
    [TestCase("[[3,1,2,2],[1,4,4,5],[2,4,2,2],[2,4,2,2]]", 3)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.EqualPairs(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
