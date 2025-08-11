using LeetCode.Extensions;
using NUnit.Framework;

namespace LeetCode._2._Middle._2438._Range_Product_Queries_of_Powers;

[TestFixture(TestName = "2438. Range Product Queries of Powers")]
public class Tests
{
    [Timeout(1000)]
    [TestCase(15, "[[0,1],[2,2],[0,3]]", "[2,4,64]")]
    [TestCase(2, "[[0,0]]", "[2]")]
    [TestCase(15, "[[0,0]]", "[1]")]
    public void Test(int input1, string input2, string output)
    {
        var solution = new Solution();
        var actual = solution.ProductQueries(input1, input2.ParseIntArray2d());
        Assert.AreEqual(output.ParseIntArray(), actual);
    }
}
