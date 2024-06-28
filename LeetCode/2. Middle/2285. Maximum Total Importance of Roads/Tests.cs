using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2285._Maximum_Total_Importance_of_Roads;

[TestFixture(TestName = "2285. Maximum Total Importance of Roads")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(5, "[[0,1],[1,2],[2,3],[0,2],[1,3],[2,4]]", 43)]
    [TestCase(5, "[[0,3],[2,4],[1,3]]", 20)]
    public void Test(int input1, string input2, long output)
    {
        var solution = new Solution();
        var actual = solution.MaximumImportance(input1, input2.ParseIntArray2d());
        Assert.AreEqual(output, actual);
    }
}
