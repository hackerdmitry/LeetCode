using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._1._Easy._1128._Number_of_Equivalent_Domino_Pairs;

[TestFixture(TestName = "1128. Number of Equivalent Domino Pairs")]
public class Tests
{
    [Timeout(1000)]
    [TestCase("[[1,2],[2,1],[3,4],[5,6]]", 1)]
    [TestCase("[[1,2],[1,2],[1,1],[1,2],[2,2]]", 3)]
    public void Test(string input, int output)
    {
        var solution = new Solution();
        var actual = solution.NumEquivDominoPairs(input.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}