using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._3160._Find_the_Number_of_Distinct_Colors_Among_the_Balls;

[TestFixture(TestName = "3160. Find the Number of Distinct Colors Among the Balls")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(4, "[[1,4],[2,5],[1,3],[3,4]]", "[1,2,2,3]")]
    [TestCase(4, "[[1,4],[2,5],[1,5],[3,4]]", "[1,2,1,2]")]
    [TestCase(4, "[[0,1],[1,2],[2,2],[3,4],[4,5]]", "[1,2,2,3,4]")]
    public void Test(int input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.QueryResults(input1, input2.ParseIntArray2d());
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}
